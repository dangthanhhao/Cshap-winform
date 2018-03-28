using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form loading...");
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("Form shown...");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            var x=MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo);
            if (x == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct f = new FrmAddProduct();
            f.Text = "Them san pham moi";
            f.Show();
        }
    }
}
