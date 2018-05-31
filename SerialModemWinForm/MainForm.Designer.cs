namespace SerialModemWinForm
{
    partial class MainWindow
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
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.ModemPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModemStatus = new System.Windows.Forms.Label();
            this.textBoxATcmd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUSSD = new System.Windows.Forms.TextBox();
            this.submitAT = new System.Windows.Forms.Button();
            this.resultTestBox = new System.Windows.Forms.RichTextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.submitUssd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(16, 32);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(204, 28);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // ModemPort
            // 
            this.ModemPort.AutoSize = true;
            this.ModemPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModemPort.Location = new System.Drawing.Point(12, 9);
            this.ModemPort.Name = "ModemPort";
            this.ModemPort.Size = new System.Drawing.Size(103, 20);
            this.ModemPort.TabIndex = 1;
            this.ModemPort.Text = "Modem Ports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(732, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status";
            // 
            // ModemStatus
            // 
            this.ModemStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModemStatus.Location = new System.Drawing.Point(494, 32);
            this.ModemStatus.Name = "ModemStatus";
            this.ModemStatus.Size = new System.Drawing.Size(291, 20);
            this.ModemStatus.TabIndex = 3;
            this.ModemStatus.Text = "Not Connected";
            this.ModemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxATcmd
            // 
            this.textBoxATcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxATcmd.Location = new System.Drawing.Point(257, 124);
            this.textBoxATcmd.Name = "textBoxATcmd";
            this.textBoxATcmd.Size = new System.Drawing.Size(194, 26);
            this.textBoxATcmd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "AT Command(without AT+)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "USSD";
            // 
            // textBoxUSSD
            // 
            this.textBoxUSSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUSSD.Location = new System.Drawing.Point(257, 185);
            this.textBoxUSSD.Name = "textBoxUSSD";
            this.textBoxUSSD.Size = new System.Drawing.Size(194, 26);
            this.textBoxUSSD.TabIndex = 7;
            // 
            // submitAT
            // 
            this.submitAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAT.Location = new System.Drawing.Point(481, 121);
            this.submitAT.Name = "submitAT";
            this.submitAT.Size = new System.Drawing.Size(125, 33);
            this.submitAT.TabIndex = 8;
            this.submitAT.Text = "Submit AT";
            this.submitAT.UseVisualStyleBackColor = true;
            this.submitAT.Click += new System.EventHandler(this.submitAT_Click);
            // 
            // resultTestBox
            // 
            this.resultTestBox.Location = new System.Drawing.Point(15, 252);
            this.resultTestBox.Name = "resultTestBox";
            this.resultTestBox.Size = new System.Drawing.Size(770, 186);
            this.resultTestBox.TabIndex = 9;
            this.resultTestBox.Text = "";
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(16, 67);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(99, 31);
            this.buttonFind.TabIndex = 10;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(121, 68);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(99, 31);
            this.buttonConnect.TabIndex = 11;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // submitUssd
            // 
            this.submitUssd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUssd.Location = new System.Drawing.Point(481, 182);
            this.submitUssd.Name = "submitUssd";
            this.submitUssd.Size = new System.Drawing.Size(125, 33);
            this.submitUssd.TabIndex = 12;
            this.submitUssd.Text = "Submit USSD";
            this.submitUssd.UseVisualStyleBackColor = true;
            this.submitUssd.Click += new System.EventHandler(this.submitUssd_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitUssd);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.resultTestBox);
            this.Controls.Add(this.submitAT);
            this.Controls.Add(this.textBoxUSSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxATcmd);
            this.Controls.Add(this.ModemStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModemPort);
            this.Controls.Add(this.comboBoxPorts);
            this.Name = "MainWindow";
            this.Text = "Serial Modem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label ModemPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ModemStatus;
        private System.Windows.Forms.TextBox textBoxATcmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUSSD;
        private System.Windows.Forms.Button submitAT;
        private System.Windows.Forms.RichTextBox resultTestBox;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button submitUssd;
    }
}

