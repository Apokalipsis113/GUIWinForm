namespace GUIWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.cbBinnaryFiles = new System.Windows.Forms.CheckBox();
            this.cbClear = new System.Windows.Forms.CheckBox();
            this.bSaveInFile = new System.Windows.Forms.Button();
            this.bLoadFromFile = new System.Windows.Forms.Button();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bStartAutoGenegation = new System.Windows.Forms.Button();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.bGenegateOnce = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.tabControlServer = new System.Windows.Forms.TabControl();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageDataGrid = new System.Windows.Forms.TabPage();
            this.lAverangeData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.tabControlServer.SuspendLayout();
            this.tabPageChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabPageDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabClient);
            this.tabControl.Controls.Add(this.tabServer);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(804, 361);
            this.tabControl.TabIndex = 0;
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.cbBinnaryFiles);
            this.tabClient.Controls.Add(this.cbClear);
            this.tabClient.Controls.Add(this.bSaveInFile);
            this.tabClient.Controls.Add(this.bLoadFromFile);
            this.tabClient.Controls.Add(this.tbFrequency);
            this.tabClient.Controls.Add(this.label3);
            this.tabClient.Controls.Add(this.bStartAutoGenegation);
            this.tabClient.Controls.Add(this.tbMax);
            this.tabClient.Controls.Add(this.tbMin);
            this.tabClient.Controls.Add(this.bGenegateOnce);
            this.tabClient.Controls.Add(this.label2);
            this.tabClient.Controls.Add(this.label1);
            this.tabClient.Controls.Add(this.tbData);
            this.tabClient.Controls.Add(this.bAdd);
            this.tabClient.Location = new System.Drawing.Point(4, 29);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(796, 328);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Клиент";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // cbBinnaryFiles
            // 
            this.cbBinnaryFiles.AutoSize = true;
            this.cbBinnaryFiles.Location = new System.Drawing.Point(638, 38);
            this.cbBinnaryFiles.Name = "cbBinnaryFiles";
            this.cbBinnaryFiles.Size = new System.Drawing.Size(114, 17);
            this.cbBinnaryFiles.TabIndex = 16;
            this.cbBinnaryFiles.Text = "Бинарные файлы";
            this.cbBinnaryFiles.UseVisualStyleBackColor = true;
            // 
            // cbClear
            // 
            this.cbClear.AutoSize = true;
            this.cbClear.Location = new System.Drawing.Point(543, 38);
            this.cbClear.Name = "cbClear";
            this.cbClear.Size = new System.Drawing.Size(76, 17);
            this.cbClear.TabIndex = 15;
            this.cbClear.Text = "Заменить";
            this.cbClear.UseVisualStyleBackColor = true;
            // 
            // bSaveInFile
            // 
            this.bSaveInFile.Location = new System.Drawing.Point(421, 78);
            this.bSaveInFile.Name = "bSaveInFile";
            this.bSaveInFile.Size = new System.Drawing.Size(106, 23);
            this.bSaveInFile.TabIndex = 14;
            this.bSaveInFile.Text = "Сохранить";
            this.bSaveInFile.UseVisualStyleBackColor = true;
            this.bSaveInFile.Click += new System.EventHandler(this.BSaveInFile_Click);
            // 
            // bLoadFromFile
            // 
            this.bLoadFromFile.Location = new System.Drawing.Point(421, 36);
            this.bLoadFromFile.Name = "bLoadFromFile";
            this.bLoadFromFile.Size = new System.Drawing.Size(106, 23);
            this.bLoadFromFile.TabIndex = 13;
            this.bLoadFromFile.Text = "Загрузить";
            this.bLoadFromFile.UseVisualStyleBackColor = true;
            this.bLoadFromFile.Click += new System.EventHandler(this.BLoadFromFile_Click);
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(27, 138);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(160, 20);
            this.tbFrequency.TabIndex = 12;
            this.tbFrequency.Text = "1000";
            this.tbFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Частота генерации (мс)";
            // 
            // bStartAutoGenegation
            // 
            this.bStartAutoGenegation.Location = new System.Drawing.Point(206, 136);
            this.bStartAutoGenegation.Name = "bStartAutoGenegation";
            this.bStartAutoGenegation.Size = new System.Drawing.Size(100, 23);
            this.bStartAutoGenegation.TabIndex = 10;
            this.bStartAutoGenegation.Text = "Генератор";
            this.bStartAutoGenegation.UseVisualStyleBackColor = true;
            this.bStartAutoGenegation.Click += new System.EventHandler(this.BStartAutoGenegation_Click);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(112, 85);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(75, 20);
            this.tbMax.TabIndex = 8;
            this.tbMax.Text = "3";
            this.tbMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(25, 85);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(75, 20);
            this.tbMin.TabIndex = 7;
            this.tbMin.Text = "1";
            this.tbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bGenegateOnce
            // 
            this.bGenegateOnce.Location = new System.Drawing.Point(206, 78);
            this.bGenegateOnce.Name = "bGenegateOnce";
            this.bGenegateOnce.Size = new System.Drawing.Size(100, 23);
            this.bGenegateOnce.TabIndex = 6;
            this.bGenegateOnce.Text = "Сгенерировать";
            this.bGenegateOnce.UseVisualStyleBackColor = true;
            this.bGenegateOnce.Click += new System.EventHandler(this.BGenegateOnce_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Максимальное";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Минимальное";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(27, 36);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(160, 20);
            this.tbData.TabIndex = 1;
            this.tbData.Text = "2";
            this.tbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(206, 34);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // tabServer
            // 
            this.tabServer.Controls.Add(this.tabControlServer);
            this.tabServer.Location = new System.Drawing.Point(4, 29);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabServer.Size = new System.Drawing.Size(796, 328);
            this.tabServer.TabIndex = 1;
            this.tabServer.Text = "Данные";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // tabControlServer
            // 
            this.tabControlServer.Controls.Add(this.tabPageChart);
            this.tabControlServer.Controls.Add(this.tabPageDataGrid);
            this.tabControlServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlServer.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControlServer.Location = new System.Drawing.Point(3, 3);
            this.tabControlServer.Name = "tabControlServer";
            this.tabControlServer.SelectedIndex = 0;
            this.tabControlServer.Size = new System.Drawing.Size(790, 322);
            this.tabControlServer.TabIndex = 0;
            // 
            // tabPageChart
            // 
            this.tabPageChart.Controls.Add(this.chart);
            this.tabPageChart.Location = new System.Drawing.Point(4, 29);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChart.Size = new System.Drawing.Size(782, 289);
            this.tabPageChart.TabIndex = 0;
            this.tabPageChart.Text = "График";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 30;
            chartArea1.Area3DStyle.Rotation = 20;
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Aqua;
            chartArea1.BorderColor = System.Drawing.Color.DarkGray;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Navy;
            series1.Legend = "Legend";
            series1.Name = "Data";
            dataPoint1.Color = System.Drawing.Color.Fuchsia;
            series1.Points.Add(dataPoint1);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend";
            series2.MarkerBorderWidth = 3;
            series2.Name = "AverangeData";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(776, 283);
            this.chart.TabIndex = 0;
            // 
            // tabPageDataGrid
            // 
            this.tabPageDataGrid.Controls.Add(this.lAverangeData);
            this.tabPageDataGrid.Controls.Add(this.label4);
            this.tabPageDataGrid.Controls.Add(this.dataGridView);
            this.tabPageDataGrid.Location = new System.Drawing.Point(4, 29);
            this.tabPageDataGrid.Name = "tabPageDataGrid";
            this.tabPageDataGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataGrid.Size = new System.Drawing.Size(782, 289);
            this.tabPageDataGrid.TabIndex = 1;
            this.tabPageDataGrid.Text = "Таблица";
            this.tabPageDataGrid.UseVisualStyleBackColor = true;
            // 
            // lAverangeData
            // 
            this.lAverangeData.AutoSize = true;
            this.lAverangeData.Location = new System.Drawing.Point(126, 7);
            this.lAverangeData.Name = "lAverangeData";
            this.lAverangeData.Size = new System.Drawing.Size(13, 13);
            this.lAverangeData.TabIndex = 2;
            this.lAverangeData.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Среднее значение";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnData});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(3, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(776, 245);
            this.dataGridView.TabIndex = 0;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "Номер эксперемента";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 150;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Результат";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            this.ColumnData.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 361);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Приложение";
            this.tabControl.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            this.tabServer.ResumeLayout(false);
            this.tabControlServer.ResumeLayout(false);
            this.tabPageChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabPageDataGrid.ResumeLayout(false);
            this.tabPageDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.Button bGenegateOnce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TabControl tabControlServer;
        private System.Windows.Forms.TabPage tabPageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TabPage tabPageDataGrid;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bStartAutoGenegation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lAverangeData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button bSaveInFile;
        private System.Windows.Forms.Button bLoadFromFile;
        private System.Windows.Forms.CheckBox cbClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.CheckBox cbBinnaryFiles;
    }
}

