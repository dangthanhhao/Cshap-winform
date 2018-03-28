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

namespace MenuExample
{
    public partial class Form1 : Form
    {
        bool is_save = true;//flag
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnFileNew_Click(object sender, EventArgs e)
        {
            if (!is_save)
            {
                var rs = MessageBox.Show("Do you want to save this doc?", "Warning", MessageBoxButtons.YesNoCancel);
                if (rs==DialogResult.Yes)
                {
                    mnFileSave.PerformClick();
                    textBox1.Text = "";
                    openFileDialog1.FileName = "";
                }
                else if (rs==DialogResult.No)
                {
                    textBox1.Text = "";
                    openFileDialog1.FileName = "";
                }
            }
            else
            {
                textBox1.Text = "";
                openFileDialog1.FileName = "";
            }
            
        }

        private void mnFileOpen_Click(object sender, EventArgs e)
        {
            if (!is_save)
            {

                var rs = MessageBox.Show("Do you want to save this doc?", "Warning", MessageBoxButtons.YesNoCancel);
                if (rs == DialogResult.Yes)
                {
                    mnFileSave.PerformClick();
                    textBox1.Text = "";
                    openFileDialog1.FileName = "";
                }
                else if (rs == DialogResult.No)
                {
                    
                }
            }
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {

                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void mnFileSave_Click(object sender, EventArgs e)
        {
            //2 truong hop
            //1.new
            //2.open
            if (openFileDialog1.FileName.Equals(""))
            {
                //new
                mnFileSaveAs.PerformClick();
                is_save = true;
            }
            else
            {
                //opening
                File.WriteAllText(openFileDialog1.FileName, textBox1.Text);
                is_save = true;

            }
           
        }

        private void mnFileSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                openFileDialog1.FileName = saveFileDialog1.FileName;
                
                is_save = true;
            }
        }

        private void mnFilePageSetup_Click(object sender, EventArgs e)
        {

        }

        private void mnFilePrint_Click(object sender, EventArgs e)
        {

        }

        private void mnFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            is_save = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
