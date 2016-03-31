using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace GitTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            WebClient wc = new WebClient();

            if (sf.ShowDialog() == DialogResult.OK)
            {
                wc.DownloadDataAsync(new Uri("http://www.filedropper.com/test_49"), sf.FileName);
                wc.DownloadDataCompleted += Wc_DownloadDataCompleted;
                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
            }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Increment(e.ProgressPercentage);
        }

        private void Wc_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            MessageBox.Show("File Downloded!");
        }
    }
}
