using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewExample
{
    public partial class frmStudentDetails : Form
    {
        public frmStudentDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check validate
            try
            {
                int.Parse(txtID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Id invalid!");
                txtID.Focus();
                txtID.SelectAll();
                return;
            }
            if (txtStudentName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter student name!");
                txtStudentName.Focus();
                return;
            }
            if (cbbBatch.SelectedIndex<0)
            {
                MessageBox.Show("Please select batch name!");
                return;
            }
            int year = DateTime.Now.Year - dtpBirthday.Value.Year;
            int diffDate = (DateTime.Now - dtpBirthday.Value).Days;
            if (year>50||year<10)
            {
                MessageBox.Show("Birthday Invalid!");
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
