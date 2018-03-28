using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentDetails : Form
    {
        Student data;
        public StudentDetails(Student s)
        {
            data = s;
            InitializeComponent();
            bindingSource1.DataSource = s;
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void StudentDetails_Shown(object sender, EventArgs e)
        {

        }
    }
}
