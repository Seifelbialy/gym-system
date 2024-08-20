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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            // Check if the coach combobox is used
            if (coachcombobox.SelectedItem == null)
            {
                MessageBox.Show("Please select a coach.");
                return;
            }

            // Check if the type combobox is used
            if (typecombobox.SelectedItem == null)
            {
                MessageBox.Show("Please select a type of class.");
                return;
            }

            // Check if the time combobox is used
            if (timecombobox.SelectedItem == null)
            {
                MessageBox.Show("Please select a time.");
                return;
            }

            // Check if the day combobox is used
            if (daycombobox.SelectedItem == null)
            {
                MessageBox.Show("Please select a day.");
                return;
            }
        }

        private void modifybutton_Click(object sender, EventArgs e)
        {

        }
        //CLEAR what is written
        private void clearbutton_Click(object sender, EventArgs e)
        {
            coachcombobox.SelectedIndex = -1;
            daycombobox.SelectedIndex = -1; 
            timecombobox.SelectedIndex = -1;    
            typecombobox.SelectedIndex = -1;    

        }

        private void eqpmntnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mntncetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void repairtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void daycombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coachcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
