using System;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.IO;
using System.Xml.Serialization;
using Logic;
using System.Runtime.Serialization.Formatters.Binary;

namespace GUIWinForm
{
    public partial class Form1 : Form
    {
        #region Constructors
        public Form1()
        {
            SelectMode();       //selecting mode before create draw main window
            InitializeComponent();
            data = new ArrayList();
            cbBinnaryFiles.Checked = false;
            cbClear.Checked = false;
            timer2.Start();
        }
        #endregion

        #region variables
        /// <summary>
        /// channel for remote object
        /// </summary>
        private HttpChannel httpChnanel;

        /// <summary>
        /// main remote object
        /// </summary>
        private IProxy Proxy;

        /// <summary>
        /// internal data storage for checking for changes
        /// </summary>
        private ArrayList data;
        private double averangeForCheck = -2.22507e-308;

        #endregion

        #region methods

        /// <summary>
        ///Show dialog with choice, then star selected mode
        /// </summary>
        private void SelectMode()
        {
            Launcher launcher = new Launcher();
            while (true)
            { 
                //asking user to choose mode
                launcher.ShowDialog();
                switch (launcher.mode)
                {
                   
                    case Mode.Offline: Proxy = new OfflineProxy(); return;   // remote object is not requared, just creating object that implements the interface
                    case Mode.Online:
                        {                            
                            try
                            {
                                RemotingConfiguration.RegisterWellKnownClientType(typeof(Proxy), launcher.connectionString);    //registration of client for shared object
                                httpChnanel = new HttpChannel();
                                ChannelServices.RegisterChannel(httpChnanel, false); //registration of data channel, security is disabled, otherwise windows requires connecting additional services ISS                               
                                Proxy = new Proxy();    //creating object that implements the interface and can be remoted
                                Proxy.GetCount();       //calling some method to make sure connection was established
                            }
                            catch (Exception e)
                            {
                                //telling user about problem
                                MessageBox.Show(e.Message);
                                //interrupt execution, server can't be reached
                                Environment.Exit(0);
                                return;
                            }                           
                            return;
                        };                        
                    case Mode.Server:
                        {                          
                            try
                            {
                              
                                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Proxy), "DataServer", WellKnownObjectMode.Singleton);  //registration of server for shared class
                               
                                httpChnanel = new HttpChannel(11347); //creating a data channel with a specific port
                                ChannelServices.RegisterChannel(httpChnanel, false);    //registration of data channel, security is disabled, otherwise windows requires connecting services ISS
                            }
                            catch (Exception e)
                            {
                                {
                                    //telling user about problem, and allowing to choose mode again
                                    MessageBox.Show(e.Message);
                                    continue;
                                }
                            }
                            //dialog window will keep alive server objects and will not allow for GC delete something
                            if (DialogResult.OK == MessageBox.Show("Приложение запущеннно в режиме сервера, нажмите ОК для остановки и выхода."))
                                 Environment.Exit(0);   //object of Form1 wasn't created properly, terminating program
                        }; break;
                    default: Environment.Exit(0); break;
                }
            }
        }

        private void LoadXml()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                AddExtension = true,
                CheckFileExists = true,
                Filter = "Xml Файл данных (*.xml)| *.xml| Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            ArrayList list = new ArrayList();
            try
            {
                using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    var xmlSerializer = new XmlSerializer(typeof(ArrayList));
                    list = (ArrayList)xmlSerializer.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                //telling user about problem
                MessageBox.Show("Ошибка при попытке загрузки. {0}", e.Message);
                return;
            }
            AddFormFile(list);
        }
        private void LoadBinnary()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                AddExtension = true,
                CheckFileExists = true,
                Filter = "bin файл данных (*.bin)| *.bin| Все файлы (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            ArrayList list = new ArrayList();
            try
            {
                using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    list = (ArrayList)binaryFormatter.Deserialize(stream);
                }                
            }
            catch (Exception e)
            {
                //telling user about problem
                MessageBox.Show("Ошибка при попытке загрузки. {0}", e.Message);
                return;
            }
            AddFormFile(list);
        }

        private void AddFormFile(ArrayList list)
        {
            if (cbClear.Checked == true)
                Proxy.Clear();
            foreach (double d in list)
                Proxy.Add(d);
        }
        private void SaveXml()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                AddExtension = true,
                CheckPathExists = true,
                Filter = "Xml файл данных (*.xml)| *.xml| Все файлы (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            ArrayList list = Proxy.GetAllData();
            try
            {
                using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    var xmlSerializer = new XmlSerializer(typeof(ArrayList));
                    xmlSerializer.Serialize(stream, list);
                    stream.Close();     //close the flow so that all operations are performed
                }
            }
            catch (Exception e)
            {
                //telling user about problem
                MessageBox.Show(e.Message);
                return;
            }
        }

        private void SaveBinnary()
        {            
            //create and show save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                AddExtension = true,
                CheckPathExists = true,
                Filter = "bin файл данных (*.bin)| *.bin| Все файлы (*.*)|*.*"
            };               
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            //saving only main data, rest can be easy restored
            ArrayList list = Proxy.GetAllData();
            try
            {                   
                using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, list);
                    stream.Close();
                }
            }
            catch (Exception e)
            {
                //telling user about problem
                MessageBox.Show(e.Message);
                return;
            }           
        }

        private void ReDraw()
        {
            ArrayList tmp = Proxy.GetAllData(); //data can be added,deleted or changed by diffirent users, so in nececary to full wipe and redraw
            chart.Series["Data"].Points.Clear();
            chart.Series["AverangeData"].Points.Clear();
            dataGridView.Rows.Clear();
            for (int i = 0; i < tmp.Count; i++)
            {
                chart.Series["Data"].Points.AddXY(i, (double)tmp[i]);
                dataGridView.Rows.Add(i, (double)tmp[i]);
            }
            data = tmp;
            averangeForCheck = Proxy.GetAverangeData();
            chart.Series["AverangeData"].Points.AddXY(0, averangeForCheck);
            chart.Series["AverangeData"].Points.AddXY(Proxy.GetCount() - 1, averangeForCheck);
            lAverangeData.Text = Convert.ToString(averangeForCheck);

        }
        #endregion

        #region event handlers
        //Check min and max numbers and genegate new and put it in textbox
        private void BGenegateOnce_Click(object sender, EventArgs e)
        {
            double min;
            double max;
            try
            {
                min = Convert.ToDouble(tbMin.Text);
                max = Convert.ToDouble(tbMax.Text);
            }
            catch
            {
                MessageBox.Show("Неверный формат минимального и максимального числа");
                return;
            }
            if (max <= min)
            {
                MessageBox.Show("Максимальный предел больше либо равен минимальному");
                return;
            }
            Random r = new Random();
            tbData.Text = Convert.ToString(r.NextDouble() * (max - min) + min);
        }

        //trying to convert number form textbox to double and adding it if it's ok
        private void BAdd_Click(object sender, EventArgs e)
        {
            double tmp;
            try
            {
                tmp = Convert.ToDouble(tbData.Text);
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
                return;
            }
            Proxy.Add(tmp);
        }

        //method called automatically by timer, simple press buttons Сгенерировать, Добавить instead of user
        private void Timer1_Tick(object sender, EventArgs e)
        {
            BGenegateOnce_Click(this, new EventArgs());
            BAdd_Click(this, new EventArgs());
        }

        //start and stop generation of random number for easy test
        private void BStartAutoGenegation_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                try
                {
                    timer1.Interval = Convert.ToInt32(tbFrequency.Text);
                }
                catch
                {
                    MessageBox.Show("Неверный формат частоты генерации");
                    return;
                }
                timer1.Start();
            }
            else
                timer1.Stop();
        }

        /// <summary>
        /// There are several methods to get data up  do date from remoted object. One of them it's event, but delegates must be invoked in same thread because of security. 
        /// So server must handle object fo remoted class and monitor clients and invoke delegates properly. 
        /// But we used easy way instead - simple timer event with check state and if needed - redraw. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (Proxy.GetCount() == 0)
                return;
            if (averangeForCheck != Proxy.GetAverangeData())
            {
                ReDraw();
                return;
            }
            ArrayList tmp = Proxy.GetAllData();
            for (int i = 0; i < data.Count; i++)
                if ((double)tmp[i] != (double)data[i])
                {
                    ReDraw();
                    return;
                }
        }

        private void BSaveInFile_Click(object sender, EventArgs e)
        {
            if (cbBinnaryFiles.Checked == true)
                SaveBinnary();
            else
                SaveXml();
        }

        //save file dialog and serialize data to file 
        private void BLoadFromFile_Click(object sender, EventArgs e)
        {
            if (cbBinnaryFiles.Checked == true)
                LoadBinnary();
            else
                LoadXml();
        }
       
        #endregion


    }
}
