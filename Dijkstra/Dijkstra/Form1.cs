using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class Form1 : Form
    {
        int VOCUNG = 9999999;
        int[,] dothi;
        Label selected;
        int sodinh=0, socanh=0;
        int currentpoint;
        List<input> linput = new List<input>();

         int[] giadennguon;
         int[] dinhtruoc;
         bool[] dinhdachot;
         bool[] dinhCoDuongDenNguon;
        int layDinhTiepTheo()
        {
            int dinhTam = VOCUNG;
            for (int i = 1; i <= sodinh; i++)
            {
                if (!dinhdachot[i] && dinhCoDuongDenNguon[i])
                {
                    dinhTam = i;
                    break;
                }
            }
            if (dinhTam == VOCUNG)
                return VOCUNG;
            for (int i = dinhTam + 1; i <= sodinh; i++)
            {
                if (!dinhdachot[i] && dinhCoDuongDenNguon[i] && giadennguon[i] < giadennguon[dinhTam])
                    dinhTam = i;
            }
            return dinhTam;
        }

        void capNhapDinhTuDinh(int dinhHienTai)
        {
            for (int i = 1; i <= sodinh; i++)
            {
                if (dothi[dinhHienTai,i] != VOCUNG && !dinhdachot[i] && i != dinhHienTai)
                {
                    if (giadennguon[dinhHienTai] + dothi[dinhHienTai,i] < giadennguon[i])
                    {
                        dinhCoDuongDenNguon[i] = true;
                        giadennguon[i] = giadennguon[dinhHienTai] + dothi[dinhHienTai,i];
                        dinhtruoc[i] = dinhHienTai;
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            currentpoint = 1;

           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                giadennguon = new int[sodinh + 1];
                dinhtruoc = new int[sodinh + 1];
                giadennguon[1] = 0;
                dinhtruoc[1] = VOCUNG;
                for (int i = 2; i <= sodinh; i++)
                {
                    giadennguon[i] = VOCUNG;
                    dinhtruoc[i] = VOCUNG;
                }
                dinhdachot = new bool[sodinh + 1];
                dinhCoDuongDenNguon = new bool[sodinh + 1];
                for (int i = 1; i <= sodinh; i++)
                {
                    dinhdachot[i] = false;
                    dinhCoDuongDenNguon[i] = false;
                }
                dinhCoDuongDenNguon[1] = true;
                int dinhHienTai = 1;
                while (true)
                {
                    dinhdachot[dinhHienTai] = true;
                    capNhapDinhTuDinh(dinhHienTai);
                    dinhHienTai = layDinhTiepTheo();
                    if (dinhHienTai == VOCUNG)
                        break;
                }
                string rs = "";
                rs = "Duong di ngan nhat den dinh " + sodinh + ": " + giadennguon[sodinh] + "\r\n";
                rs += "Duong: \r\n";
                int v = sodinh;
                String duongdi = "";
                duongdi = duongdi + v;
                while (v != VOCUNG)
                {
                    if (dinhtruoc[v] != VOCUNG)
                        duongdi = dinhtruoc[v] + "->" + duongdi;
                    v = dinhtruoc[v];
                }
                rs += duongdi;
                MessageBox.Show(rs, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ee)
            {
                MessageBox.Show("Không tìm được đường đi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void loadGridView()
        {
            dothi = new int[sodinh + 1, sodinh + 1];
            for (int i = 0; i <= sodinh; i++)
            {

               
                for (int j = 1; j <= sodinh; j++)
                    if (i == j)
                        dothi[i,j] = 0;
                    else
                        dothi[i,j] = VOCUNG;

            }

            for (int i = 0; i < socanh; i++)
            {
                
                dothi[linput[i].diem1,linput[i].diem2] = linput[i].trongso;
                dothi[linput[i].diem2, linput[i].diem1] = linput[i].trongso;

            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            for (int j = 1; j < dothi.GetLength(1); j++)
            {
                dataGridView1.Columns.Add("", "");
            }
            for (int i = 1; i < dothi.GetLength(0); i++)
            {
                object[] row = new object[dothi.GetLength(1)];
                for (int j = 1; j < dothi.GetLength(1); j++)
                {
                    row[j - 1] = dothi[i, j];
                }
                dataGridView1.Rows.Add(row);

            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int x = this.PointToClient(Cursor.Position).X;
            int y = this.PointToClient(Cursor.Position).Y;
            sodinh++;
            
            Label p = new Label();
            p.Text =currentpoint.ToString();
            currentpoint++;
            p.TextAlign = ContentAlignment.MiddleCenter;
            p.Size = new Size(30, 30);
            p.BackColor = Color.Aquamarine;
            this.Controls.Add(p);
            p.Location = new Point(x,y);
            p.Click += P_Click;
            

           

           
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "Click chọn trên vùng trống để tạo ra đỉnh\r\nClick chọn vào 2 đỉnh đã tạo để điền trọng số";
            MessageBox.Show(s, "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "Chương trình minh họa GUI thuật toán tìm đường đi ngắn nhất Dijkstra\r\n Thực hiển bởi Đặng Thanh Hào - 16CNTT3\r\n Sản phẩm bài tập môn hệ phân tán\r\n GVHD: Nguyễn Hoàng Hải";
            MessageBox.Show(s, "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void P_Click(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.Red;
            if (selected==null)
            {
                selected = sender as Label;
            }
            else
            {
                Form2 testDialog = new Form2();
                if (testDialog.ShowDialog(this) == DialogResult.OK)
                {
                    int a = int.Parse(selected.Text);
                    int b = int.Parse((sender as Label).Text);
                    int c = int.Parse(testDialog.textBox1.Text);
                    input i = new input(a, b, c);
                    linput.Add(i);

                    Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
                    this.CreateGraphics().DrawLine(pen, selected.Location.X+15, selected.Location.Y+15, (sender as Label).Location.X+15, (sender as Label).Location.Y+15);
                    int xlablel = (selected.Location.X + 15 + (sender as Label).Location.X + 15) / 2;
                    int ylablel = (selected.Location.Y + 15 + (sender as Label).Location.Y + 15) / 2;
                    Label p = new Label();
                    p.Text = c.ToString();
                    p.AutoSize = true;
                    this.Controls.Add(p);
                    this.Controls[this.Controls.Count - 1].BringToFront();
                    p.Location = new Point(xlablel, ylablel);

                    socanh++;
                    loadGridView();
                }
               
                    (sender as Label).BackColor = Color.Aquamarine;
                    selected.BackColor = Color.Aquamarine;
                    selected = null;
               
                testDialog.Dispose();
            }
        }
    }
}
