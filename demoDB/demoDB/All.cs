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
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cinSQL);
            try
            {
                conn.Open();
                String sen = "select * from Customers";
                SqlCommand sqlCommand = new SqlCommand(sen, conn);
                sqlCommand = new SqlCommand(sen, conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    String Rno = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Cno")).Trim();
                    String Style = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Cname")).Trim();
                    String Price = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Sex")) + "";
                    String State = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Cid")).Trim();
                    String Tel = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Cadress")).Trim();
                    String others = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Cothers")).Trim();
                    this.dataGridView1.Rows.Add(Rno, Style, Price, State, Tel,others);
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
