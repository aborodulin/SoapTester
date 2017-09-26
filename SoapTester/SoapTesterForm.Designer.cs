namespace SoapTester
{
    partial class SoapTesterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoapTesterForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.soapTesterStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.Url = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.stopButton = new System.Windows.Forms.Button();
            this.headersTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contentTypeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.methodTextBox = new System.Windows.Forms.TextBox();
            this.acceptTextBox = new System.Windows.Forms.TextBox();
            this.versionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(876, 23);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soapTesterStatus,
            this.versionStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // soapTesterStatus
            // 
            this.soapTesterStatus.Name = "soapTesterStatus";
            this.soapTesterStatus.Size = new System.Drawing.Size(88, 17);
            this.soapTesterStatus.Text = "Enter soap data";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(12, 25);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(858, 20);
            this.urlTextBox.TabIndex = 2;
            // 
            // requestTextBox
            // 
            this.requestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestTextBox.Location = new System.Drawing.Point(12, 141);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.requestTextBox.Size = new System.Drawing.Size(485, 302);
            this.requestTextBox.TabIndex = 3;
            // 
            // responseTextBox
            // 
            this.responseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.responseTextBox.Location = new System.Drawing.Point(503, 141);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ReadOnly = true;
            this.responseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responseTextBox.Size = new System.Drawing.Size(487, 302);
            this.responseTextBox.TabIndex = 4;
            // 
            // Url
            // 
            this.Url.AutoSize = true;
            this.Url.Location = new System.Drawing.Point(12, 9);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(52, 13);
            this.Url.TabIndex = 5;
            this.Url.Text = "Server url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Request";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Response";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soap version";
            this.groupBox1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "1.2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1.1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(876, 52);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(114, 23);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // headersTextBox
            // 
            this.headersTextBox.Location = new System.Drawing.Point(116, 68);
            this.headersTextBox.Multiline = true;
            this.headersTextBox.Name = "headersTextBox";
            this.headersTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.headersTextBox.Size = new System.Drawing.Size(611, 52);
            this.headersTextBox.TabIndex = 7;
            this.headersTextBox.Text = "SOAP:Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Headers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Content-Type";
            // 
            // contentTypeTextBox
            // 
            this.contentTypeTextBox.Location = new System.Drawing.Point(733, 68);
            this.contentTypeTextBox.Name = "contentTypeTextBox";
            this.contentTypeTextBox.Size = new System.Drawing.Size(137, 20);
            this.contentTypeTextBox.TabIndex = 8;
            this.contentTypeTextBox.Text = "text/xml;charset=\"utf-8\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(873, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Accept";
            // 
            // methodTextBox
            // 
            this.methodTextBox.Location = new System.Drawing.Point(733, 107);
            this.methodTextBox.Name = "methodTextBox";
            this.methodTextBox.Size = new System.Drawing.Size(137, 20);
            this.methodTextBox.TabIndex = 8;
            this.methodTextBox.Text = "POST";
            // 
            // acceptTextBox
            // 
            this.acceptTextBox.Location = new System.Drawing.Point(876, 107);
            this.acceptTextBox.Name = "acceptTextBox";
            this.acceptTextBox.Size = new System.Drawing.Size(114, 20);
            this.acceptTextBox.TabIndex = 8;
            this.acceptTextBox.Text = "text/xml";
            // 
            // versionStatusLabel
            // 
            this.versionStatusLabel.Name = "versionStatusLabel";
            this.versionStatusLabel.Size = new System.Drawing.Size(899, 17);
            this.versionStatusLabel.Spring = true;
            this.versionStatusLabel.Text = "Version:";
            this.versionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SoapTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1002, 468);
            this.Controls.Add(this.acceptTextBox);
            this.Controls.Add(this.methodTextBox);
            this.Controls.Add(this.contentTypeTextBox);
            this.Controls.Add(this.headersTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Url);
            this.Controls.Add(this.responseTextBox);
            this.Controls.Add(this.requestTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "SoapTesterForm";
            this.Text = "Soap Tester";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.Label Url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolStripStatusLabel soapTesterStatus;
        private System.Windows.Forms.TextBox headersTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contentTypeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox methodTextBox;
        private System.Windows.Forms.TextBox acceptTextBox;
        private System.Windows.Forms.ToolStripStatusLabel versionStatusLabel;
    }
}

