using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace demoDB
{
    public partial class HStatus : Form
    {
        public HStatus()
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
                String sen = "select * from Rooms";
                SqlCommand sqlCommand = new SqlCommand(sen, conn);
                sqlCommand = new SqlCommand(sen, conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    String Rno = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Rno")).Trim();
                    String Style = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Style")).Trim();
                    String Price = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Price"))+"";
                    String State = sqlDataReader.GetString(sqlDataReader.GetOrdinal("State")).Trim();
                    String Tel = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Tel")).Trim();
                    this.dataGridView1.Rows.Add(Rno, Style, Price, State, Tel);
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
    }
}
