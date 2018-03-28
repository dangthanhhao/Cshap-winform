using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread threadDraw;
        private void Form1_Load(object sender, EventArgs e)
        {
            threadDraw = new Thread(new ThreadStart(RunDraw));
            threadDraw.Start();
        }
        int x, y;
        int d = 5;
        int h = 5, v = 0;
        int point = 0;
        int delay = 300;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (v != 0)
                    {
                        h = -5; v = 0;
                    }
                    break;
                case Keys.Right:
                    if (v != 0)
                    {
                        h = 5; v = 0;
                    }
                    break;
                case Keys.Up:
                    if (h != 0)
                    {
                        v = -5; h = 0;
                    }
                    break;
                case Keys.Down:
                    if (h != 0)
                    {
                        v = 5; h = 0;
                    }
                    break;
            }
        }

        private void RunDraw()
        {
            
            Random rnd = new Random();
            using (Graphics g = this.CreateGraphics())
            {
                x = 0; y = 10;

                while (true)
                {
                    g.FillEllipse(Brushes.Red, x, y, 5, 5);
                    Thread.Sleep(delay);
                    x += h;y += v;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                threadDraw.Abort();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
