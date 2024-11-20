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
    public partial class Form3 : Form
    {
        string connectionString = Environment.GetEnvironmentVariable("FOOTYAPP_DB_CONNECTION");
        SqlConnection con;
        public int userID { get; set; }
        public String userUsername { get; set; }


        public Form3()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Database connection string is not set in the environment variables.");
            }

            con = new SqlConnection(connectionString);

            InitializeComponent();

            terminiDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            terminiDataGridView.MultiSelect = false;
            terminiDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(terminiDataGridView_RowPrePaint);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            usernameText.Text = userUsername;

            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Termin", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            terminiDataGridView.DataSource = dtbl;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            DateTime terminDate = terminDateFilter.Value;
            string formattedTerminDate = terminDate.ToString("dd.MM.yyyy.");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Termin WHERE date = @Date", con);
            cmd.Parameters.AddWithValue("@Date", formattedTerminDate);

            var result = cmd.ExecuteScalar();
            if (result == null)
            {
                MessageBox.Show("Nema termina za odabrani dan");
            }
            else
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM termin WHERE date = '" + formattedTerminDate + "'", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                terminiDataGridView.DataSource = dtbl;
            }
        }

        private void terminiDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String name = "";
            String date = "";
            String time = "";
            String place = "";
            int numberOfPlayers;
            float averagePlayerScore = 0;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = terminiDataGridView.Rows[e.RowIndex];
                string valueInColumn4 = terminiDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                name = clickedRow.Cells[1].Value.ToString();
                date = clickedRow.Cells[2].Value.ToString();
                time = clickedRow.Cells[3].Value.ToString();
                place = clickedRow.Cells[4].Value.ToString();
                numberOfPlayers = Convert.ToInt32(clickedRow.Cells[5].Value.ToString());

                try
                {
                    if (clickedRow.Cells[6].Value.ToString() == "")
                    {
                        averagePlayerScore = 0;
                    }
                    else
                    {
                        averagePlayerScore = float.Parse(clickedRow.Cells[6].Value.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (valueInColumn4 == "arena centar")
                    {
                        Form4 f4 = new Form4();
                        f4.Name = name;
                        f4.Date = date;
                        f4.Time = time;
                        f4.Place = place;
                        f4.NumberOfPlayers = numberOfPlayers;
                        f4.AveragePlayerScore = averagePlayerScore;
                        f4.userID = userID;
                        f4.userUsername = userUsername;
                        f4.ShowDialog();
                    }
                    else
                    {
                        Form5 f5 = new Form5();
                        f5.Name = name;
                        f5.Date = date;
                        f5.Time = time;
                        f5.Place = place;
                        f5.NumberOfPlayers = numberOfPlayers;
                        f5.AveragePlayerScore = averagePlayerScore;
                        f5.userUsername = userUsername;
                        f5.ShowDialog();
                    }
                }
            }
        }

        private void terminiDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Termin", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            terminiDataGridView.DataSource = dtbl;
        }
    }
}
