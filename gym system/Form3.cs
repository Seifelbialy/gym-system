using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_system
{// database connection with SSMS
    public partial class Form3 : Form
    {
     static string sql = "Data Source=MSI;Initial Catalog=gymDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //member info validation
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string firstName;
            int age;

            string gender = genderComboBox.SelectedItem as string;
            string membership = membershipComboBox.SelectedItem as string;


            Guna.UI2.WinForms.Guna2TextBox firstNameTextBox = this.firstNameTextBox;
       
            Guna.UI2.WinForms.Guna2TextBox ageTextBox = this.ageTextBox;
           

            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter a first name.");
                firstNameTextBox.Focus();
                return;
            }

            if (!Regex.IsMatch(firstNameTextBox.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Please enter a valid first name.");
                firstNameTextBox.Focus();
                return;
            }

            firstName = firstNameTextBox.Text;

            if (!int.TryParse(ageTextBox.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                ageTextBox.Focus();
                return;
            }

            if (age < 18 || age > 100)
            {
                MessageBox.Show("Please enter an age between 18 and 100.");
                ageTextBox.Focus();
                return;
            }

    

            if (string.IsNullOrWhiteSpace(membership))
            {
                MessageBox.Show("Please select a membership.");
                membershipComboBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please select a gender.");
                genderComboBox.Focus();
                return;
            }
            try
            {
                //connecting to database
                con.Open();


                SqlCommand command = new SqlCommand("INSERT INTO members (memberName, Age, Gender, Membership) VALUES (@firstName, @age, @gender, @membership)", con);

                command.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                command.Parameters.AddWithValue("@age", ageTextBox.Text);
                command.Parameters.AddWithValue("@membership", membershipComboBox.Text);
                command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                //if error happened , message box of failure
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Member added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add member.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}