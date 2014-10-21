namespace HSServer
{
    partial class FormServer
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
            this.labelServerAddress = new System.Windows.Forms.Label();
            this.textBoxServerAddress = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelServerPort = new System.Windows.Forms.Label();
            this.textBoxConnectedClients = new System.Windows.Forms.TextBox();
            this.labelConnectedClients = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelServerStatus = new System.Windows.Forms.Label();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.buttonStopServer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.comboBoxTypeOfData = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressName = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxFileSize = new System.Windows.Forms.TextBox();
            this.labelDataSize = new System.Windows.Forms.Label();
            this.textBoxFileNumber = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelServerAddress
            // 
            this.labelServerAddress.AutoSize = true;
            this.labelServerAddress.Location = new System.Drawing.Point(13, 13);
            this.labelServerAddress.Name = "labelServerAddress";
            this.labelServerAddress.Size = new System.Drawing.Size(78, 13);
            this.labelServerAddress.TabIndex = 0;
            this.labelServerAddress.Text = "Server address";
            // 
            // textBoxServerAddress
            // 
            this.textBoxServerAddress.Location = new System.Drawing.Point(136, 10);
            this.textBoxServerAddress.Name = "textBoxServerAddress";
            this.textBoxServerAddress.Size = new System.Drawing.Size(246, 20);
            this.textBoxServerAddress.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labelServerPort
            // 
            this.labelServerPort.AutoSize = true;
            this.labelServerPort.Location = new System.Drawing.Point(13, 39);
            this.labelServerPort.Name = "labelServerPort";
            this.labelServerPort.Size = new System.Drawing.Size(97, 13);
            this.labelServerPort.TabIndex = 2;
            this.labelServerPort.Text = "Server port number";
            // 
            // textBoxConnectedClients
            // 
            this.textBoxConnectedClients.Location = new System.Drawing.Point(136, 111);
            this.textBoxConnectedClients.Name = "textBoxConnectedClients";
            this.textBoxConnectedClients.Size = new System.Drawing.Size(246, 20);
            this.textBoxConnectedClients.TabIndex = 7;
            // 
            // labelConnectedClients
            // 
            this.labelConnectedClients.AutoSize = true;
            this.labelConnectedClients.Location = new System.Drawing.Point(13, 114);
            this.labelConnectedClients.Name = "labelConnectedClients";
            this.labelConnectedClients.Size = new System.Drawing.Size(92, 13);
            this.labelConnectedClients.TabIndex = 6;
            this.labelConnectedClients.Text = "Connected clients";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(246, 20);
            this.textBox4.TabIndex = 5;
            // 
            // labelServerStatus
            // 
            this.labelServerStatus.AutoSize = true;
            this.labelServerStatus.Location = new System.Drawing.Point(13, 88);
            this.labelServerStatus.Name = "labelServerStatus";
            this.labelServerStatus.Size = new System.Drawing.Size(69, 13);
            this.labelServerStatus.TabIndex = 4;
            this.labelServerStatus.Text = "Server status";
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Location = new System.Drawing.Point(16, 231);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(118, 56);
            this.buttonStartServer.TabIndex = 8;
            this.buttonStartServer.Text = "Start server";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            // 
            // buttonStopServer
            // 
            this.buttonStopServer.Location = new System.Drawing.Point(140, 231);
            this.buttonStopServer.Name = "buttonStopServer";
            this.buttonStopServer.Size = new System.Drawing.Size(118, 56);
            this.buttonStopServer.TabIndex = 9;
            this.buttonStopServer.Text = "Stop server";
            this.buttonStopServer.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 56);
            this.button3.TabIndex = 10;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(418, 36);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(227, 251);
            this.listBoxData.TabIndex = 14;
            // 
            // comboBoxTypeOfData
            // 
            this.comboBoxTypeOfData.FormattingEnabled = true;
            this.comboBoxTypeOfData.Location = new System.Drawing.Point(418, 10);
            this.comboBoxTypeOfData.Name = "comboBoxTypeOfData";
            this.comboBoxTypeOfData.Size = new System.Drawing.Size(227, 21);
            this.comboBoxTypeOfData.TabIndex = 15;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripProgressName});
            this.statusStrip.Location = new System.Drawing.Point(0, 300);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(658, 22);
            this.statusStrip.TabIndex = 17;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripProgressName
            // 
            this.toolStripProgressName.Name = "toolStripProgressName";
            this.toolStripProgressName.Size = new System.Drawing.Size(84, 17);
            this.toolStripProgressName.Text = "progressName";
            // 
            // textBoxFileSize
            // 
            this.textBoxFileSize.Location = new System.Drawing.Point(136, 163);
            this.textBoxFileSize.Name = "textBoxFileSize";
            this.textBoxFileSize.Size = new System.Drawing.Size(246, 20);
            this.textBoxFileSize.TabIndex = 21;
            // 
            // labelDataSize
            // 
            this.labelDataSize.AutoSize = true;
            this.labelDataSize.Location = new System.Drawing.Point(13, 166);
            this.labelDataSize.Name = "labelDataSize";
            this.labelDataSize.Size = new System.Drawing.Size(60, 13);
            this.labelDataSize.TabIndex = 20;
            this.labelDataSize.Text = "Size of files";
            // 
            // textBoxFileNumber
            // 
            this.textBoxFileNumber.Location = new System.Drawing.Point(136, 137);
            this.textBoxFileNumber.Name = "textBoxFileNumber";
            this.textBoxFileNumber.Size = new System.Drawing.Size(246, 20);
            this.textBoxFileNumber.TabIndex = 19;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(13, 140);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(77, 13);
            this.labelData.TabIndex = 18;
            this.labelData.Text = "Number of files";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 322);
            this.Controls.Add(this.textBoxFileSize);
            this.Controls.Add(this.labelDataSize);
            this.Controls.Add(this.textBoxFileNumber);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.comboBoxTypeOfData);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonStopServer);
            this.Controls.Add(this.buttonStartServer);
            this.Controls.Add(this.textBoxConnectedClients);
            this.Controls.Add(this.labelConnectedClients);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelServerStatus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelServerPort);
            this.Controls.Add(this.textBoxServerAddress);
            this.Controls.Add(this.labelServerAddress);
            this.Name = "FormServer";
            this.Text = "Server administration";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServerAddress;
        private System.Windows.Forms.TextBox textBoxServerAddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelServerPort;
        private System.Windows.Forms.TextBox textBoxConnectedClients;
        private System.Windows.Forms.Label labelConnectedClients;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelServerStatus;
        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.Button buttonStopServer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.ComboBox comboBoxTypeOfData;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProgressName;
        private System.Windows.Forms.TextBox textBoxFileSize;
        private System.Windows.Forms.Label labelDataSize;
        private System.Windows.Forms.TextBox textBoxFileNumber;
        private System.Windows.Forms.Label labelData;
    }
}

