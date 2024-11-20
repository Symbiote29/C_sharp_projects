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

namespace FootyC_
{
    public partial class Form6 : Form
    {
        string connectionString = Environment.GetEnvironmentVariable("FOOTYAPP_DB_CONNECTION");
        SqlConnection con;
        public string? userUsername { get; set; }
        public float score { get; set; }
        public Form6()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Database connection string is not set in the environment variables.");
            }

            con = new SqlConnection(connectionString);

            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label2.Text = this.userUsername;
            con.Open();
            scoreComboBox.SelectedIndex = 0;
        }

        private void ratePlayerButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmdInsert = new SqlCommand("UPDATE Player SET score = @Score WHERE username = @Username", con);
            cmdInsert.Parameters.AddWithValue("@Score", score);
            cmdInsert.Parameters.AddWithValue("@Username", userUsername);
            cmdInsert.ExecuteNonQuery();
            MessageBox.Show("Rating submitted");
            this.Close();
        }

        private void scoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            score = float.Parse(scoreComboBox.Text);
        }
    }
}
