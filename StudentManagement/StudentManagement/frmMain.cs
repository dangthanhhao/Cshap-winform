using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmMain : Form
    {
        User c_user;
        public frmMain(User user)
        {
            InitializeComponent();
            c_user = user;
        }

        private void LoadStudent()
        {
            using (var db = new StudentDBDataContext())
            {
                var list = from s in db.Students
                           select new 
                           {
                               s.Id,
                               s.StudentName,
                               s.Birthday,
                               s.Batch.BatchName,
                               s.Phone,
                               s.Address
                           };
                dgvStudent.DataSource = list;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStudent f = new frmStudent(0);
            if (f.ShowDialog()==DialogResult.OK)
            {
                LoadStudent();
            }
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStudent f = new frmStudent(int.Parse(dgvStudent.SelectedRows[0].Cells[0].Value.ToString()));
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadStudent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(new Batches().ShowDialog() == DialogResult.OK)
            {
                LoadStudent();
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            new frmUsers().ShowDialog();
        }
    }
}
