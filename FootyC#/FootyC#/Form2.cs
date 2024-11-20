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

namespace FootyC_
{
    public partial class Form2 : Form
    {
        string connectionString = Environment.GetEnvironmentVariable("FOOTYAPP_DB_CONNECTION");
        SqlConnection con;
        public Form2()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Database connection string is not set in the environment variables.");
            }

            con = new SqlConnection(connectionString);

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Player(firstname, surname, username, password, dateofbirth) VALUES(@firstname, @surname, @username, @password, @dateofbirth)", con);
                cmd.Parameters.AddWithValue("@firstname", firstnameTextBox.Text);
                cmd.Parameters.AddWithValue("@surname", surnameTextBox.Text);
                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                DateTime selectedDate = dateOfBirth.Value;
                string formattedDate = selectedDate.ToString("dd.MM.yyyy.");
                cmd.Parameters.AddWithValue("@dateofbirth", formattedDate);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                this.Close();
            }
        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(passwordCheckBox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
