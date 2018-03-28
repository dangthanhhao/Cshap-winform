using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> ds;
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void LoadStudent()
        {
            lstStudent.Items.Clear();
            XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
            Stream fs=null;
            try
            {
                fs = File.OpenRead("data.xml");
                ds = xml.Deserialize(fs) as List<Student>;
            }
            catch (Exception)
            {
                ds = new List<Student>();
            }
            finally
            {
                if (fs!=null) fs.Close();
            }
            foreach (var item in ds)
            {
                ListViewItem ltem= lstStudent.Items.Add(item.name);
                ltem.SubItems.Add(item.age.ToString());
                ltem.SubItems.Add(item.address);
                ltem.SubItems.Add(item.Sclass.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LoadStudent();
        }
        private void SaveStudent()
        {
            Stream fs = File.Create("Data.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            serializer.Serialize(fs, ds);
            fs.Close();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            StudentDetails fstudent = new StudentDetails(s);
            fstudent.ShowDialog();
            if (fstudent.DialogResult==DialogResult.OK)
            {
                ds.Add(s);
            }
            SaveStudent();
            LoadStudent();
           

        }

        private void lstStudent_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void lstStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lstStudent.GetItemAt(e.X, e.Y);
            Student s = ds.Where(x => x.name.Equals(item.Text)).SingleOrDefault();
            new StudentDetails(s).ShowDialog();
        }
    }
}
