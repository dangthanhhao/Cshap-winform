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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        private void LoadUsers()
        {
            using (var db = new StudentDBDataContext())
            {
                dgvUser.DataSource = db.Users; //.ToList()
            }
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserInfo f = new frmUserInfo(0);
            if (f.ShowDialog()==DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvUser.SelectedRows[0].Cells["Id"].Value.ToString());
            frmUserInfo f = new frmUserInfo(id);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }
    }
}
