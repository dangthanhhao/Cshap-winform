using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Management
{
    public partial class frmNewTask : Form
    {
        public frmNewTask()
        {
            InitializeComponent();
        }


        private void pnImportant_Click(object sender, EventArgs e)
        {
            pnVienImportant.BackColor = Color.Blue;
            pnVienMedium.BackColor = SystemColors.Control;
            pnVienUsual.BackColor = SystemColors.Control;
            lbImportant.Text = "Quan trọng";
        }

        private void pnMedium_Click(object sender, EventArgs e)
        {

            pnVienMedium.BackColor = Color.Blue;
            pnVienImportant.BackColor = SystemColors.Control;
            pnVienUsual.BackColor = SystemColors.Control;
            lbImportant.Text = "Thường ngày";

        }

        private void pnUsual_Click(object sender, EventArgs e)
        {
            pnVienUsual.BackColor = Color.Blue;
            pnVienImportant.BackColor = SystemColors.Control;
            pnVienMedium.BackColor = SystemColors.Control;
            lbImportant.Text = "Đã hoàn thành";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cbbLapLai.Enabled = true;
                cbbTimeNoti.Enabled = true;
                lblLapLai.Enabled = true;
                lbTimeNoti.Enabled = true;
            }
            else
            {
                cbbLapLai.Enabled = false;
                cbbTimeNoti.Enabled = false;
                lblLapLai.Enabled = false;
                lbTimeNoti.Enabled = false;
            }
        }
    }
}
