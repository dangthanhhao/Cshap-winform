using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                string s = "Hello, Hai Rom";
                Font f = new Font("Times New Roman", 18, FontStyle.Bold | FontStyle.Italic);

                var size= g.MeasureString(s, f);

                Brush b = Brushes.Red;
                g.DrawString(s, f, b, 20, 50);
                g.DrawRectangle(new Pen(Brushes.Blue,2), 20, 50, size.Width, size.Height);

                g.DrawLine(new Pen(Brushes.Blue,2),50,20,100,200);
                g.DrawRectangle(new Pen(Brushes.Blue, 2), 200, 150, 200, 100);
                int m = 3;
                g.DrawRectangle(new Pen(Brushes.Red, 2), 200 + m, 150 + m, 200 - 2 * m, 100 - 2 * m);

                g.DrawEllipse(new Pen(Brushes.Red, 2), 200 + m, 150 + m, 200 - 2 * m, 100 - 2 * m);
                g.FillEllipse(Brushes.Green, 100, 100, 100, 100);
            }

        }
    }
}
