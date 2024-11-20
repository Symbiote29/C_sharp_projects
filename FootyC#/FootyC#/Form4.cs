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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace FootyC_
{
    public partial class Form4 : Form
    {
        string connectionString = Environment.GetEnvironmentVariable("FOOTYAPP_DB_CONNECTION");
        SqlConnection con;
        public string? Name { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? Place { get; set; }
        public int NumberOfPlayers { get; set; }
        public float AveragePlayerScore { get; set; }

        public string? userUsername { get; set; }

        public int userID { get; set; }

        public Form4()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Database connection string is not set in the environment variables.");
            }

            con = new SqlConnection(connectionString);

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDaPlayerList = new SqlDataAdapter("SELECT firstname, surname, username, dateofbirth, score FROM TerminPlayerList WHERE date = '" + this.Date + "'", con);
            DataTable dtblPlayerList = new DataTable();
            sqlDaPlayerList.Fill(dtblPlayerList);
            playerListDataGridView.DataSource = dtblPlayerList;

            label8.Text = this.Name;
            label9.Text = this.Date;
            label10.Text = this.Time;
            label11.Text = this.Place;
            label12.Text = this.NumberOfPlayers.ToString();
            label13.Text = calculateAveragePlayerScore().ToString();
        }

        private float calculateAveragePlayerScore()
        {
            float totalScore = 0;
            int rowCount = playerListDataGridView.Rows.Count;

            for (int i = 0; i < rowCount - 1; i++)
            {
                if (playerListDataGridView.Rows[i].Cells[4].Value != DBNull.Value && playerListDataGridView.Rows[i].Cells[4].Value != null)
                {
                    totalScore += Convert.ToSingle(playerListDataGridView.Rows[i].Cells[4].Value);
                }
            }

            float averagePlayerScore = rowCount > 1 ? totalScore / (rowCount - 1) : 0;
            return averagePlayerScore;
        }


        private void prijaviseButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM TerminPlayerList WHERE username = @Username AND date = @Date", con);
            cmdCheck.Parameters.AddWithValue("@Username", userUsername);
            cmdCheck.Parameters.AddWithValue("@Date", this.Date);
            int existingUserCount = (int)cmdCheck.ExecuteScalar();

            if (existingUserCount > 0)
            {
                MessageBox.Show("User already exists in TerminPlayerList.");
                return;
            }

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT firstname, surname, username, dateofbirth, score FROM Player WHERE id = @UserID", con);
            sqlDa.SelectCommand.Parameters.AddWithValue("@UserID", userID);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            foreach (DataRow row in dtbl.Rows)
            {
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO TerminPlayerList (date, firstname, surname, username, dateofbirth, score) VALUES (@Date, @Firstname, @Surname, @Username, @DateOfBirth, @Score)", con);
                cmdInsert.Parameters.AddWithValue("@Date", this.Date);
                cmdInsert.Parameters.AddWithValue("@Firstname", row["firstname"]);
                cmdInsert.Parameters.AddWithValue("@Surname", row["surname"]);
                cmdInsert.Parameters.AddWithValue("@Username", row["username"]);
                cmdInsert.Parameters.AddWithValue("@DateOfBirth", row["dateofbirth"]);
                cmdInsert.Parameters.AddWithValue("@Score", row["score"]);
                cmdInsert.ExecuteNonQuery();
            }

            SqlDataAdapter sqlDaPlayerList = new SqlDataAdapter("SELECT firstname, surname, username, dateofbirth, score FROM TerminPlayerList WHERE date = '" + this.Date + "'", con);
            DataTable dtblPlayerList = new DataTable();
            sqlDaPlayerList.Fill(dtblPlayerList);
            playerListDataGridView.DataSource = dtblPlayerList;

            label13.Text = calculateAveragePlayerScore().ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmdDelete = new SqlCommand("DELETE FROM TerminPlayerList WHERE username = @Username AND date = @Date", con);
            cmdDelete.Parameters.AddWithValue("@Username", userUsername);
            cmdDelete.Parameters.AddWithValue("@Date", this.Date);
            cmdDelete.ExecuteNonQuery();

            SqlDataAdapter sqlDaPlayerList = new SqlDataAdapter("SELECT firstname, surname, username, dateofbirth, score FROM TerminPlayerList WHERE date = '" + this.Date + "'", con);
            DataTable dtblPlayerList = new DataTable();
            sqlDaPlayerList.Fill(dtblPlayerList);
            playerListDataGridView.DataSource = dtblPlayerList;

            label13.Text = calculateAveragePlayerScore().ToString();

            MessageBox.Show("Inserted data has been deleted.");
        }

        private void playerListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = playerListDataGridView.Rows[e.RowIndex];
                string valueInColumn4 = playerListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                Form6 f6 = new Form6();
                f6.userUsername = valueInColumn4;
                f6.ShowDialog();
            }
        }
    }
}
