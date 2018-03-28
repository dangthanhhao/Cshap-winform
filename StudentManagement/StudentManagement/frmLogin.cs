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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
    private void checkLogin()
        {
            using (var db=new StudentDBDataContext())
            {
                var user = db.Users.Where(x => x.UserName.Equals(txtUser.Text)).SingleOrDefault();
                if (user!=null)
                {
                    if (user.Password.Equals(txtPass.Text))
                    {
                        new frmMain(user).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password invalid");
                    }
                }
                else
                {
                    MessageBox.Show("User name not exists!");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkLogin();
        }
    }
}
