namespace Demo
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textAntiGateKey = new System.Windows.Forms.TextBox();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonReportBad = new System.Windows.Forms.Button();
            this.buttonRecognizeFile = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRecognizeUrl = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AntiGate ключ:";
            // 
            // textAntiGateKey
            // 
            this.textAntiGateKey.Location = new System.Drawing.Point(12, 25);
            this.textAntiGateKey.MaxLength = 32;
            this.textAntiGateKey.Name = "textAntiGateKey";
            this.textAntiGateKey.Size = new System.Drawing.Size(295, 20);
            this.textAntiGateKey.TabIndex = 1;
            // 
            // buttonBalance
            // 
            this.buttonBalance.Location = new System.Drawing.Point(313, 23);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(105, 23);
            this.buttonBalance.TabIndex = 2;
            this.buttonBalance.Text = "Баланс";
            this.buttonBalance.UseVisualStyleBackColor = true;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // textResult
            // 
            this.textResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textResult.Location = new System.Drawing.Point(0, 144);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(423, 108);
            this.textResult.TabIndex = 3;
            this.textResult.Text = "Результат";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 282);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(423, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel1.Text = "http://geograph.us";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Enabled = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(300, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "2014 © Geograph";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonReportBad
            // 
            this.buttonReportBad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonReportBad.Location = new System.Drawing.Point(0, 252);
            this.buttonReportBad.Name = "buttonReportBad";
            this.buttonReportBad.Size = new System.Drawing.Size(423, 30);
            this.buttonReportBad.TabIndex = 5;
            this.buttonReportBad.Text = "Пожаловаться на неправильно разгаданный текст";
            this.buttonReportBad.UseVisualStyleBackColor = true;
            this.buttonReportBad.Click += new System.EventHandler(this.buttonReportBad_Click);
            // 
            // buttonRecognizeFile
            // 
            this.buttonRecognizeFile.Location = new System.Drawing.Point(313, 62);
            this.buttonRecognizeFile.Name = "buttonRecognizeFile";
            this.buttonRecognizeFile.Size = new System.Drawing.Size(105, 23);
            this.buttonRecognizeFile.TabIndex = 8;
            this.buttonRecognizeFile.Text = "Распознать";
            this.buttonRecognizeFile.UseVisualStyleBackColor = true;
            this.buttonRecognizeFile.Click += new System.EventHandler(this.buttonRecognizeFile_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(12, 64);
            this.textFile.MaxLength = 32;
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(269, 20);
            this.textFile.TabIndex = 7;
            this.textFile.Text = "Captcha.jpg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Распознать капчу из файла:";
            // 
            // buttonRecognizeUrl
            // 
            this.buttonRecognizeUrl.Location = new System.Drawing.Point(313, 105);
            this.buttonRecognizeUrl.Name = "buttonRecognizeUrl";
            this.buttonRecognizeUrl.Size = new System.Drawing.Size(105, 23);
            this.buttonRecognizeUrl.TabIndex = 11;
            this.buttonRecognizeUrl.Text = "Распознать";
            this.buttonRecognizeUrl.UseVisualStyleBackColor = true;
            this.buttonRecognizeUrl.Click += new System.EventHandler(this.buttonRecognizeUrl_Click);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(12, 107);
            this.textUrl.MaxLength = 32;
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(295, 20);
            this.textUrl.TabIndex = 10;
            this.textUrl.Text = "http://upload.wikimedia.org/wikipedia/commons/6/69/Captcha.jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Распознать капчу по ссылке:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(282, 62);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowse.TabIndex = 12;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Изображения|*.jpeg;*.jpg;*.png;*.gif";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 304);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonRecognizeUrl);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRecognizeFile);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.buttonReportBad);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonBalance);
            this.Controls.Add(this.textAntiGateKey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример использования класса AntiGate";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAntiGateKey;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button buttonReportBad;
        private System.Windows.Forms.Button buttonRecognizeFile;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRecognizeUrl;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

