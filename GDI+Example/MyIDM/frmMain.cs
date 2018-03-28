using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyIDM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string save_path = Application.StartupPath+"\\Downloads";
        private void btnAddURL_Click(object sender, EventArgs e)
        {
            frmAddURL f = new frmAddURL();
            if (f.ShowDialog()==DialogResult.OK)
            {
                if (!Directory.Exists(save_path))
                {
                    Directory.CreateDirectory(save_path);
                }
                string url = f.textBox1.Text;
                string file = save_path + "\\" + url.Split('/').Last();
                ListViewItem item = lstDownload.Items.Add(url);
                item.SubItems.Add(file);
                item.SubItems.Add("");
                item.SubItems.Add("");
                WebClient client = new WebClient();
                client.DownloadProgressChanged += (sdr, ev) =>
                {
                    item.SubItems[2].Text = (ev.TotalBytesToReceive / 1024) + "KB";
                    item.SubItems[3].Text = ev.ProgressPercentage + "%";
                };
                client.DownloadFileCompleted += (sdr, ev) =>
                {
                    item.SubItems[3].Text = "Compelete";
                };
                client.DownloadFileAsync(new Uri(url), file);
            }
        }
    }
}
