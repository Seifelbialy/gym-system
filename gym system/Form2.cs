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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        //add member button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           Form3 form3 = new Form3();   
            form3.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
        }
        //payment form
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();  
            form4.Show();
            this.Hide();
        }
        //to database of members
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();  
            form7.Show();
        }
        //classes form
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();  
            form6.Show();
            this.Hide();
        }
    }
}
