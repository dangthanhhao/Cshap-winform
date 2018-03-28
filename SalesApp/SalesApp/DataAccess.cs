using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public class DataAccess
    {
        private static string strCon = "Data Source=.;Initial Catalog=HaiRomShop;Integrated Security=True";
        public static bool CheckLogin(string username,string password)
        {
            bool result = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(strCon);
                string s = "select Id from [Table] where UserName='" + username + "' and Password='" + password + "'";
                SqlCommand cmd = new SqlCommand(s, conn);
            
                conn.Open();
                var reader = cmd.ExecuteReader();
                result = reader.HasRows;
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn?.Close();
            }
            return result;

        }
        public static bool CheckLogin(Table user)
        {
            using (var db=new DataClasses1DataContext())
            {
                var x = db.Tables.Where(d => d.UserName.Equals(user.UserName) && d.Password.Equals(user.Password)).FirstOrDefault();
                return x != null;
            }
        }
    }
}
