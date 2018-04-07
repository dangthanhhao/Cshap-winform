using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMatrix();

        }
        

        
        #region Peoperties
        private List<List<Button>> matrix;
        public static List<Work> listCongViec;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += btn_Click;

                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }

            SetDefaultDate();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            //DailyPlan daily = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            //daily.ShowDialog();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }

        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }
        List<Work> sourceListView;
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
            loadListView();
            

        }

        private void loadListView()
        {
            if (listCongViec != null)
            {
                sourceListView = listCongViec.Where(p => isEqualDate(p.Date, dtpkDate.Value)).ToList();
                if (sourceListView != null)
                {
                    listView1.Items.Clear();

                    foreach (var item in sourceListView)
                    {
                        int imageindex;
                        switch (item.Important)
                        {
                            case "Quan trọng":
                                imageindex = 0;
                                break;
                            case "Thường ngày":
                                imageindex = 1;
                                break;
                            case "Đã hoàn thành":
                                imageindex = 2;
                                break;
                            default:
                                imageindex = 0;
                                break;
                        }
                        var x = listView1.Items.Add(item.Date.ToShortTimeString(), imageindex);
                        x.SubItems.Add(item.Name);
                    }

                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnToDay_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        #endregion
      

        private void Form1_Load(object sender, EventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(28, 25);
            imageList.Images.Add(global::Time_Management.Properties.Resources.important);
            imageList.Images.Add(global::Time_Management.Properties.Resources.usual);
            imageList.Images.Add(global::Time_Management.Properties.Resources.done);
            listView1.SmallImageList = imageList;
            listView1.Columns[1].Width = -2;
            

            try
            {
                LoadJson();
            }
            catch
            {
                
            }
            if (listCongViec==null)
            {
                listCongViec = new List<Work>();
            }

            loadListView();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            /* Work a = new Work("Hào", "Đặng Thanh Hào", "Hàng tháng", "Gia đình", "Quan trọng", new DateTime(1998, 04, 04), "Trong ngày", true);
             frmNewTask f = new frmNewTask(a);
             f.ShowDialog();
             SaveJson(a);*/

            Work a = new Work();
            var x = new frmNewTask(a).ShowDialog();
            if (x == DialogResult.OK)
            {
                listCongViec.Add(a);
                SaveJson();
                MessageBox.Show("Thêm công việc thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        static void SaveJson()
        {
            string data = JsonConvert.SerializeObject(listCongViec);
            if (!Directory.Exists("data")) Directory.CreateDirectory("data");

            File.WriteAllText(Application.StartupPath+"/data/Data.json", data);
        }
        void LoadJson()
        {
            if (!File.Exists(Application.StartupPath + "/data/Data.json"))
            {
                return;
            }
            string data = File.ReadAllText(Application.StartupPath + "/data/Data.json");
            listCongViec = JsonConvert.DeserializeObject<List<Work>>(data);
        }
    

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }





}

