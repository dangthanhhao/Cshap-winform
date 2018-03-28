using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaiRomShop
{
    public partial class frmMain : Form
    {
        User c_user;
        public frmMain(User c_user)
        {
            InitializeComponent();
            this.c_user = c_user;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void loadOrders()
        {
            using (var db=new ShopDataContext())
            {
                DateTime b_month = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var orders = from o in db.Orders
                          //   where o.OrderDate>= b_month&& o.OrderDate>DateTime.Now
                             orderby o.Status, o.Id descending
                             select new //noi bang co truong moi tham chieu
                             {
                                 o.Id,
                                 o.OrderDate,
                                 o.Customer,
                                 Employee=o.User.FullName,
                                 Total=o.OrderDetails.Count>0? o.OrderDetails.Sum(d=> d.Quantity*d.Price):0,
                                 Status=o.Status==1?"Pending":"Finish"
                             };
                dgvOrdersList.DataSource = orders;
                dgvOrdersList.Columns["Id"].DefaultCellStyle.Format = "D5";
                dgvOrdersList.Columns["total"].DefaultCellStyle.Format = "N0";
                dgvOrdersList.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                
            }
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            loadOrders();            
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmOrderDetails f = new frmOrderDetails(0, c_user.Id);
            f.ShowDialog();
            loadOrders();
        }

        private void dgvOrdersList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvOrdersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int order_id = int.Parse(dgvOrdersList.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            frmOrderDetails f = new frmOrderDetails(order_id, c_user.Id);
            f.ShowDialog();
            loadOrders();
        }
    }
}
