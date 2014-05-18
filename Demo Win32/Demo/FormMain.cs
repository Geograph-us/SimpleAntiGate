using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleAntiGate;

namespace Demo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://geograph.us");
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            AntiGate.AntiGateKey = textAntiGateKey.Text;
            textResult.Text = AntiGate.GetBalance();
        }

        private void buttonRecognizeUrl_Click(object sender, EventArgs e)
        {
            AntiGate.AntiGateKey = textAntiGateKey.Text;
            textResult.Text = AntiGate.Recognize(textUrl.Text);
        }

        private void buttonReportBad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AntiGate.LastCaptchaId))
            {
                AntiGate.AntiGateKey = textAntiGateKey.Text;
                AntiGate.ReportBad(AntiGate.LastCaptchaId);
            }
        }

        private void buttonRecognizeFile_Click(object sender, EventArgs e)
        {
            AntiGate.AntiGateKey = textAntiGateKey.Text;
            textResult.Text = AntiGate.Recognize(textFile.Text);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel && !string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                textFile.Text = openFileDialog1.FileName;
            }
        }
    }
}
