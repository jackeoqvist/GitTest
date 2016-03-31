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
                wc.DownloadDataAsync(new Uri("https://www.dropbox.com/s/erom0g5vol34noc/IMG_0159.PNG?dl=0"), sf.FileName);
                wc.DownloadDataCompleted += Wc_DownloadDataCompleted;
            }
        }

        private void Wc_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            MessageBox.Show("File Downloded!");
        }
    }
}
