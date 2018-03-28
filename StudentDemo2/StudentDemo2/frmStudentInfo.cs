using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDemo2
{
    public partial class frmStudentInfo : Form
    {
        int id=0;
        Student data;
        StudentDBDataContext db = new StudentDBDataContext();
        public frmStudentInfo(int id)
        {
            InitializeComponent();
            this.id = id; 
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            if (id==0)
            {
                data = new Student();
                data.Birthday = DateTime.Parse("1990/1/1");
                db.Students.InsertOnSubmit(data);
            }
            else
            {
                data = db.Students.Where(x => x.Id == id).SingleOrDefault();
            }

            cbbBatch.DataSource = db.Batches.ToList();
            cbbBatch.ValueMember = "Id";
            cbbBatch.DisplayMember = "BatchName";

            txtId.DataBindings.Add("Text", data, "Id");
            txtStudentName.DataBindings.Add("Text", data, "StudentName");
            cbbBatch.DataBindings.Add("SelectedValue", data, "BatchId");
            dtpBirthday.DataBindings.Add("Value", data, "Birthday");
            
            txtPhone.DataBindings.Add("Text", data, "Phone");
            txtAddress.DataBindings.Add("Text", data, "Address");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                db.SubmitChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
