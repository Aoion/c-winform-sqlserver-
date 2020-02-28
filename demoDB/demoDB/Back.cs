using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace demoDB
{
    public partial class Back : Form
    {
        public Back()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cinSQL);
            try
            {
                conn.Open();
                int num = 0;
                String sen0 = "select Price from CR_INF where Rno =" + textBox1.Text.Trim();
                SqlCommand sqlCommand = new SqlCommand(sen0, conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    num = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Price"));
                }
                sqlDataReader.Close();
                textBox3.Text = num*0.2 + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cinSQL);
            try
            {
                conn.Open();
                String sen = "delete from CR_INF where Rno="+textBox1.Text.Trim();
                SqlCommand sqlCommand = new SqlCommand(sen,conn);
                sqlCommand.ExecuteNonQuery();
                sen = "update Rooms set State='房间空' where Rno=" + textBox1.Text.Trim();
                sqlCommand = new SqlCommand(sen, conn);
                sqlCommand.ExecuteNonQuery();
                sen = "delete from Customers where Cid=" + textBox2.Text.Trim();
                SuccessDelete successDelete = new SuccessDelete();
                successDelete.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
