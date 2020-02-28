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
    public partial class QueryC : Form
    {
        public QueryC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cinSQL);
            try
            {
                conn.Open();
                String sen = "select * from Record";
                SqlCommand sqlCommand = new SqlCommand(sen, conn);
                sqlCommand = new SqlCommand(sen, conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    String Rno = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Rno")).Trim();
                    String Record = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Record")).Trim();
                    this.dataGridView1.Rows.Add(Rno, Record);
                }
                sqlDataReader.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cinSQL);
            String Rno = textBox1.Text.Trim();
            String record = textBox2.Text.Trim();
            String others = "";
            try
            {
                conn.Open();
                String sen = "insert into Record values('" + Rno + "','" + record + "','" + others + "')";
                SqlCommand sqlCommand = new SqlCommand(sen, conn);
                sqlCommand = new SqlCommand(sen, conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                
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
