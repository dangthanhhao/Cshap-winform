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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void LoadStudents()
        {
            using (var db=new StudentDBDataContext())
            {
                var students = from s in db.Students
                               select new
                               {
                                   s.Id,
                                   s.StudentName,
                                   s.Batch.BatchName,
                                   s.Birthday,
                                   s.Phone,
                                   s.Address
                               };
                dgvStudents.DataSource = students;
                dgvStudents.Columns["Id"].HeaderText = "Mã sinh viên";
                dgvStudents.Columns["StudentName"].HeaderText = "Tên sinh viên";
                dgvStudents.Columns["BatchName"].HeaderText = "Lớp";
                dgvStudents.Columns["Birthday"].HeaderText = "Ngày sinh";
                dgvStudents.Columns["Birthday"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvStudents.Columns["Id"].DefaultCellStyle.Format = "D5";
                dgvStudents.Columns["Id"].Width = 90;
                dgvStudents.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvStudents.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(new frmStudentInfo(0).ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvStudents.Rows[e.RowIndex].Cells["Id"].Value.ToString());
           ;
            if (new frmStudentInfo(id).ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count==0)
            {
                return;
            }
            using (var db=new StudentDBDataContext())
            {
                foreach (DataGridViewRow row in dgvStudents.SelectedRows)
                {
                    int id = int.Parse(row.Cells["Id"].Value.ToString());
                    var s = db.Students.Where(x => x.Id == id).SingleOrDefault();
                    try
                    {
                        db.Students.DeleteOnSubmit(s);
                    }
                    catch
                    {

                    }
                }
                db.SubmitChanges();
            }
            LoadStudents();
        }
    }
}
