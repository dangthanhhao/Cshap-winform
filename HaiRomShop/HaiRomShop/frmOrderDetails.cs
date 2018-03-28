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
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails(int order_id, int user_id)
        {
            InitializeComponent();
            this.order_id = order_id;
            this.user_id = user_id;
        }
        Order order;
        int user_id;
        int order_id;//flag
        ShopDataContext db = new ShopDataContext();
        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            if (order_id == 0)
            {
                order = new Order()
                {
                    OrderDate = DateTime.Now,
                    Customer = "",
                    UserId = user_id,
                    Status = 1
                };
                db.Orders.InsertOnSubmit(order);
                db.SubmitChanges();
            }
            else
            {
                order = db.Orders.Where(x => x.Id == order_id).SingleOrDefault();
                //check edit permision
                if (order.UserId != user_id || order.Status != 1) 
                {
                    dtpOrderDate.Enabled = false;
                    
                }
            }
            txtUser.Text = order.User.ToString();
            dtpOrderDate.Value = order.OrderDate;
            txtOrderID.Text = order.Id.ToString("D5");
            txtCustomer.Text = order.Customer;

            var od_list = from d in db.OrderDetails
                          where d.OrderId == order.Id
                          select new
                          {
                              d.Id,
                              d.Product.ProductName,
                              d.Product.Unit,
                              d.Price,
                              d.Quantity,
                              Total = d.Price * d.Quantity
                          };
            dataGridView1.DataSource = od_list;
            cbbProductName.DataSource = db.Products;
            cbbProductName.ValueMember = "Id";
            cbbProductName.DisplayMember = "ProductName";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
