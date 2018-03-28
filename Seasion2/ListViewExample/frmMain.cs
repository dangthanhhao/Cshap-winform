using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewExample
{
    public partial class frmMain : Form
    {
        List<Student> listStudent;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listStudent = DataAccess.LoadData();
            foreach (var s in listStudent)
            {
                ListViewItem item = lstStudent.Items.Add(s.Id.ToString());
                item.SubItems.Add(s.StudentName);
                item.SubItems.Add(s.Batch);
                item.SubItems.Add(s.BirthDay.ToString("dd/MM/yyyy"));
                item.SubItems.Add(s.Phone);
                item.SubItems.Add(s.Address);
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudentDetails f = new frmStudentDetails();
            if (f.ShowDialog()==DialogResult.OK)
            {
                //save and show
                Student s = new Student()
                {
                    Id = int.Parse(f.txtID.Text),
                    StudentName = f.txtStudentName.Text,
                    Batch = f.cbbBatch.SelectedItem.ToString(),
                    BirthDay = f.dtpBirthday.Value,
                    Address = f.txtAddress.Text,
                    Phone = f.txtPhone.Text
                    
                };
                listStudent.Add(s);
                DataAccess.SaveData(listStudent);
                this.frmMain_Load(this, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudent.SelectedItems.Count==0)
            {
                return;
            }
            var rs = MessageBox.Show("Are you sure to delete?", "Warning", MessageBoxButtons.YesNo);
            if (rs==DialogResult.Yes)
            {
                ListViewItem item = lstStudent.SelectedItems[0];
                int id = int.Parse(item.Text);
                var s=listStudent.Where(x => x.Id == id).FirstOrDefault();
                
                if (s!=null)
                {
                    listStudent.Remove(s);
                    DataAccess.SaveData(listStudent);
                }
                lstStudent.Items.Remove(item);
            }
        }

        private void lstStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lstStudent.GetItemAt(e.X, e.Y);

            frmStudentDetails f = new frmStudentDetails();
            
        }

        private void lstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
