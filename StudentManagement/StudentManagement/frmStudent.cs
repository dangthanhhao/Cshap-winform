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
    public partial class frmStudent : Form
    {
        Student data;
        StudentDBDataContext db = new StudentDBDataContext();
        int student_id = 0;
        //id=0 add
        //id>0 edit
        public frmStudent(int id)
        {
            InitializeComponent();
            this.student_id = id;
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            if (student_id==0)
            {
                data = new Student();

            }
            else
            {
                data = db.Students.Where(x => x.Id == student_id).SingleOrDefault();
            }
            bsStudent.DataSource = data;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Co van de");
            }
        }
    }
}
