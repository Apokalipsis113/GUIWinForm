using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIWinForm
{
    public enum Mode {Offline, Online, Server };
    public partial class Launcher : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Launcher()
        {
            InitializeComponent();
        }
        //contains selected mode
        public Mode mode;
        //contains string for connectin to server
        public string connectionString;
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (RBOffline.Checked == true)
                mode = Mode.Offline;
            if (RBOnline.Checked == true)
            {
                mode = Mode.Online;
                connectionString = textBoxConnectionString.Text;
            }
            if (RBServer.Checked == true)
                mode = Mode.Server;
            this.Close();
        }
    }
}
