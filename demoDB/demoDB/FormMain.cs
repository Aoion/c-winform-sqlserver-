using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace demoDB
{
    public partial class FormMain : Form
    {
        public int s = 5000;
        public int x = 0;

        public FormMain(String username)
        {
            InitializeComponent();
            label2.Text = username;
            System.Timers.Timer  timer = new System.Timers.Timer();
            timer.Interval = 1000;
            int i = 5;
            timer.Elapsed += delegate
            {
                i++;
                    Image image = Image.FromFile("C:\\Users\\caitian\\Pictures\\Camera Roll\\" + i + ".jpg");
                    pictureBox1.Image = image;
                    if (i == 14)
                    {
                        i = 5;
                    }
                };
            timer.Start();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            HStatus hStatus = new HStatus();
            hStatus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            In hIn = new In();
            hIn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mangagecustomer mangagecustomer = new Mangagecustomer();
            mangagecustomer.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Back back = new Back();
            back.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QueryC queryC = new QueryC();
            queryC.Show();
        }
    }
}



