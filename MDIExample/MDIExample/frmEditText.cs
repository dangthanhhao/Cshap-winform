using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIExample
{
    public partial class frmEditText : Form
    {
        public frmEditText()
        {
            InitializeComponent();
        }

        private void frmEditText_Shown(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(this.Text);
        }
    }
}
