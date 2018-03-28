using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaiRomShop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void checkLogin()
        {
            //after check validate
            using (var db= new ShopDataContext())
            {
                var user = db.Users.Where(x => x.UserName.Equals(txtUserName.Text)).SingleOrDefault();
                if (user!=null)
                {
                    if (user.Password.Equals(txtPassword.Text)){
                        new frmMain(user).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password invalid!");
                    }
                }
                else
                {
                    MessageBox.Show("Username not exist!");
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }
    }
}
