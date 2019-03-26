namespace GUIWinForm
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RBOnline = new System.Windows.Forms.RadioButton();
            this.RBOffline = new System.Windows.Forms.RadioButton();
            this.RBServer = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RBOnline
            // 
            this.RBOnline.AutoSize = true;
            this.RBOnline.Location = new System.Drawing.Point(155, 86);
            this.RBOnline.Name = "RBOnline";
            this.RBOnline.Size = new System.Drawing.Size(63, 17);
            this.RBOnline.TabIndex = 0;
            this.RBOnline.TabStop = true;
            this.RBOnline.Text = "Онлайн";
            this.RBOnline.UseVisualStyleBackColor = true;
            // 
            // RBOffline
            // 
            this.RBOffline.AutoSize = true;
            this.RBOffline.Location = new System.Drawing.Point(155, 40);
            this.RBOffline.Name = "RBOffline";
            this.RBOffline.Size = new System.Drawing.Size(73, 17);
            this.RBOffline.TabIndex = 1;
            this.RBOffline.TabStop = true;
            this.RBOffline.Text = "Оффлайн";
            this.RBOffline.UseVisualStyleBackColor = true;
            // 
            // RBServer
            // 
            this.RBServer.AutoSize = true;
            this.RBServer.Location = new System.Drawing.Point(155, 63);
            this.RBServer.Name = "RBServer";
            this.RBServer.Size = new System.Drawing.Size(62, 17);
            this.RBServer.TabIndex = 2;
            this.RBServer.TabStop = true;
            this.RBServer.Text = "Сервер";
            this.RBServer.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(153, 179);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(102, 112);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.Size = new System.Drawing.Size(267, 20);
            this.textBoxConnectionString.TabIndex = 4;
            this.textBoxConnectionString.Text = "http://localhost:11347/DataServer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите режим работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес сервера";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 218);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConnectionString);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.RBServer);
            this.Controls.Add(this.RBOffline);
            this.Controls.Add(this.RBOnline);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Launcher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBOnline;
        private System.Windows.Forms.RadioButton RBOffline;
        private System.Windows.Forms.RadioButton RBServer;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}