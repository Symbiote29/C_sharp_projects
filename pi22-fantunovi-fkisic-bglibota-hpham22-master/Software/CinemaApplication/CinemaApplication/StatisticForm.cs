using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApplication
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            mostPopularGenreChart.Visible = true;
            mostPopularMoviesChart.Visible = false;

            mostPopularGenreChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            mostPopularMoviesChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            GetGenrePopularity();
            statisticLabel.Text = "genre popularity";

            changeTheme();
        }

        private void GetGenrePopularity()
        {
            using (var context = new CinemaDatabase())
            {
                var query = context.Movies
                    .GroupBy(x => x.Genre)
                    .Select(g => new { Genre = g.Key, Tickets = g.Sum(x => x.NumberOfTickets) })
                    .OrderBy(o => o.Tickets);

                mostPopularGenreChart.Series["Genre"].XValueMember = "Genre";
                mostPopularGenreChart.Series["Genre"].YValueMembers = "Tickets";
                mostPopularGenreChart.DataSource = query.ToList();
                mostPopularGenreChart.DataBind();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popularGenreBtn_Click(object sender, EventArgs e)
        {
            mostPopularGenreChart.Visible = true;
            mostPopularMoviesChart.Visible = false;
            GetGenrePopularity();
            statisticLabel.Text = "genre popularity";
        }

        private void popularMovieBtn_Click(object sender, EventArgs e)
        {
            mostPopularGenreChart.Visible = false;
            mostPopularMoviesChart.Visible = true;
            GetMoviePopularity();
            statisticLabel.Text = "movie popularity";
        }

        private void GetMoviePopularity()
        {
            using (var context = new CinemaDatabase())
            {
                var query = context.Movies
                    .GroupBy(x => x.MovieName)
                    .Select(g => new { MovieName = g.Key, Tickets = g.Sum(x => x.NumberOfTickets) })
                    .OrderBy(o => o.Tickets);

                
                mostPopularMoviesChart.Series["MovieName"].XValueMember = "MovieName";
                mostPopularMoviesChart.Series["MovieName"].YValueMembers = "Tickets";
                mostPopularMoviesChart.DataSource = query.ToList();
                mostPopularMoviesChart.DataBind();
            }
        }

        private void changeTheme()
        {
            BackColor = GlobalVariable.principalColor;

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.Font = new Font(GlobalVariable.fontStyle, 18);
                    c.ForeColor = GlobalVariable.fontColor;
                }
            }
        }
    }
}
