using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ListViewExample
{
    public class DataAccess
    {
        private static string file = "student.xml";
        public static void SaveData(List<Student> data)
        {
            
            Stream stream = null;
            try
            {
                stream = File.Create(file);
                XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
                xml.Serialize(stream, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }

            }
            
        }
        public static List<Student> LoadData()
        {
            List<Student> data;
            Stream stream = null;
            try
            {
                stream = File.OpenRead(file);
                XmlSerializer xml = new XmlSerializer(typeof( List < Student >));
                data = xml.Deserialize(stream) as List<Student>;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                data = new List<Student>();
            }
            finally
            {
                if (stream!=null)
                {
                    stream.Close();
                }
               
            }
            return data;
        }
    }
}
