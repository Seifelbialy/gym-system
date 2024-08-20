using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_system
{
    public partial class Form7 : Form
    {
        static string sql = "Data Source=MSI;Initial Catalog=gymDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);

        public Form7()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        //function to return the datatable
        public DataTable loadUserTable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM members";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //to load the database in the application
        private void Form7_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loadUserTable();
        }
        //to refer for the selected cells in the textboxs
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            nameTextbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ageTextBox.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            genderTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            membershipTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        //update button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE members SET memberName=@firstName, Age=@age, Gender=@gender, Membership= @membership WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@firstName",nameTextbox.Text);
                cmd.Parameters.AddWithValue("@age",ageTextBox.Text);
                cmd.Parameters.AddWithValue("@membership",membershipTextBox.Text);
                cmd.Parameters.AddWithValue("@gender",genderTextBox.Text);
                cmd.Parameters.AddWithValue("@id",dataGridView1.CurrentRow.Cells[2].Value);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1.DataSource = loadUserTable();
                MessageBox.Show("Update successful!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message);
            }
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //delete button
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM members WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[2].Value);
                cmd.ExecuteNonQuery();
                con.Close();

                dataGridView1.DataSource = loadUserTable();
                MessageBox.Show("Delete successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
        }
        //search button
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string searchName = Searchtextbox.Text;
            try
            {
                
                {
                    string query = "SELECT * FROM members WHERE MemberName LIKE @searchName + '%'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@searchName", searchName);
                       
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        con.Close() ;
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while searching for member: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
