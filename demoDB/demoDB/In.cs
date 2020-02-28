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
    public partial class In : Form
    {
        public In()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empty form = new Empty();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            TimeSpan ts = dt2 - dt1;
            int diffDays = ts.Days+1;
            textBox3.Text = diffDays + "";
            String Rno = textBox1.Text.Trim();
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cinSQL);
            try
            {
                conn.Open();
                String sen0 = "select Price from Rooms where Rno =" +Rno;
                SqlCommand sqlCommand = new SqlCommand(sen0, conn);
                sqlCommand = new SqlCommand(sen0, conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int price = 0;
                while (sqlDataReader.Read())
                {
                    price = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Price"));
                }
                sqlDataReader.Close();
                textBox4.Text = price * diffDays + "";
                textBox5.Text = price * diffDays * 0.2 + "";
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

        private void button2_Click(object sender, EventArgs e)
        {

            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cinSQL);
            String ID = textBox2.Text;
            try
            {
                conn.Open();
                String sen0 = "select Cno from Customers where Cid =" + ID;
                SqlCommand sqlCommand = new SqlCommand(sen0, conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                String Cno = null;
                while (sqlDataReader.Read())
                {
                   Cno = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Cno")).Trim();
                }
                sqlDataReader.Close();
                String sen = "insert into CR_INF values('" + textBox1.Text.Trim() + "','" + Cno + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
                sqlCommand = new SqlCommand(sen, conn);
                sqlCommand.ExecuteNonQuery();
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
