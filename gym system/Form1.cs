using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //login validation
        private void guna2Button1_Click(object sender, EventArgs e)
        {


            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password you entered is incorrect, try again");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        /* private void label2_Click(object sender, EventArgs e)
         {
             txtUserName.Clear();
             txtPassword.Clear();
             txtUserName.Focus();
         }*/

        /*  private void label3_Click(object sender, EventArgs e)
          {
              Application.Exit();
          }*/
        /*   Form2 form2 = new Form2();      
           form2.Show();

       }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //exit
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

