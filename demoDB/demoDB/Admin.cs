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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(cinSQL);
            
            try
            {
                sqlConnection.Open();
                String id = textBox1.Text.Trim();
                String pwd = textBox2.Text.Trim();
                String sen = "delete from Login where Username="+id;
                SqlCommand sqlCommand = new SqlCommand(sen, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(cinSQL);

            try
            {
                sqlConnection.Open();
                String id = textBox1.Text.Trim();
                String pwd = textBox2.Text.Trim();
                String sen = "insert into Login values('" + id + "','" + pwd + "')";
                SqlCommand sqlCommand = new SqlCommand(sen, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}

