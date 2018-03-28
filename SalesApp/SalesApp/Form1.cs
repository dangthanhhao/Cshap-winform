using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Login()
        {
            var user = new Table()
            {
                UserName = textBox1.Text,
                Password = textBox2.Text,
            };
            //check validate
            if (DataAccess.CheckLogin(user))
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("AA");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
