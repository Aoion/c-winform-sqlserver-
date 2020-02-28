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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text.ToString().Trim();
            String password = textBox2.Text.ToString().Trim();
            Connection connection = new Connection();
            if (connection.Yn(username,password))
            {
                String username2 = textBox1.Text;
                FormMain main = new FormMain(username2);
                this.Hide();
                main.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="admin"&&textBox2.Text.Trim()=="admin")
            {
                Admin admin = new Admin();
              //  this.Hide();
                admin.Show();
                
            }
            else
            {
                PasswordWrong passwordWrong = new PasswordWrong();
                passwordWrong.Show();
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }
    }
    public class Connection
    {
        public bool Yn(String username,String password)
        {
            string cinSQL = "Data Source=DESKTOP-94NMRIT\\SQLSERVER;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cinSQL);
            try
            {
                string sel = "select * from Login";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sel, conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    string name = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Username")).Trim();
                    string pwd = sqlDataReader.GetString(sqlDataReader.GetOrdinal("password")).Trim();
                    if (name.Equals(username) && pwd.Equals(password))

                    {
                        sqlDataReader.Close();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            return false;

        }
    }
}
