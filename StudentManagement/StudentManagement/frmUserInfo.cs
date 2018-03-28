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
    public partial class frmUserInfo : Form
    {
        int id = 0;
        User data;
        StudentDBDataContext db = new StudentDBDataContext();

        public frmUserInfo(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.SubmitChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi!");
            }
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            if (id==0)
            {
                data = new User();
                db.Users.InsertOnSubmit(data);
            }
            else{
                data = db.Users.Where(x => x.Id == id).SingleOrDefault();
            }
            bsUser.DataSource = data;
        }
    }
}
