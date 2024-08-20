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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
                // Check if the string input is empty
                if (string.IsNullOrEmpty(nametxtbox.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid member name.");
                    return;
                }

                // Check if the int input is empty or not a number
                int intValue;
                if (!int.TryParse(amounttxtbox.Text.Trim(), out intValue))
                {
                    MessageBox.Show("Please enter a valid amount value.");
                    return;
                }

                // Check if the date time picker is not set
                if (guna2DateTimePicker1.Value == null || guna2DateTimePicker1.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Please select a date and time.");
                    return;
                }
            if (guna2DateTimePicker1.Value.Date != DateTime.Today)
            {
                MessageBox.Show("Please select today's date.");
                return;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            nametxtbox.Clear();
            amounttxtbox.Clear();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
