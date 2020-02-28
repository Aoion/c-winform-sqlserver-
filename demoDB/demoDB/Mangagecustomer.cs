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
    public partial class Mangagecustomer : Form
    {
        public Mangagecustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String id = textBox2.Text;
            String sex = textBox3.Text;
            String adress = textBox4.Text;
            String other = textBox5.Text;
            Connection connection = new Connection();
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cinSQL);
            try
            {
                conn.Open();
                int num = 0;
                String Cno = null;
                String sen0 = "select Cno from Customers";
                SqlCommand sqlCommand = new SqlCommand(sen0, conn);
                sqlCommand = new SqlCommand(sen0,conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Cno = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Cno")).Trim();
                }
                sqlDataReader.Close();
                int.TryParse(Cno, out num);
                num += 1;
                Cno = num + "";
                String sen = "insert into Customers values('" + Cno + "','" + name + "','" + sex + "','" + id + "','" + adress + "','" + other + "')";
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            All all = new All();
            all.Show();
        }
    }
}
