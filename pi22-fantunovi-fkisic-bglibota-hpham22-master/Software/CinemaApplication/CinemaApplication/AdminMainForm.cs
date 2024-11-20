using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie;

namespace CinemaApplication
{
    public partial class AdminMainForm : Form
    {
        User activeUser;
        public AdminMainForm(User user)
        {
            InitializeComponent();
            activeUser = user;
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            GetMovieData();
            activeUserLabel.Text = "admin";
            AddMovieLabel.Cursor = Cursors.Hand;
            StatisticsLabel.Cursor = Cursors.Hand;
            SettingsLabel.Cursor = Cursors.Hand;
            ProfileLabel.Cursor = Cursors.Hand;
            logOutButton.Cursor = Cursors.Hand;
            clearFilterBtn.Cursor = Cursors.Hand;
            changeTheme();
        }
        private void GetMovieData()
        {
            movieDataGridView.DataSource = null;
            movieDataGridView.DataSource = MovieList();
            movieDataGridView.Columns["Movie_ID"].Visible = false;
            movieDataGridView.Columns["Reviews"].Visible = false;

        }
        private object MovieList()
        {
            using (var context = new CinemaDatabase())
            {
                var query = from m in context.Movies
                            orderby m.MovieName
                            select m;

                return query.ToList();
            }
        }

        private void genrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genrName = genrComboBox.Text;
            using (var context = new CinemaDatabase())
            {
                var query = from m in context.Movies
                            where m.Genre.Contains(genrName)
                            select m;

                movieDataGridView.DataSource = null;
                movieDataGridView.DataSource = query.ToList();
                movieDataGridView.Columns["Movie_ID"].Visible = false;
                movieDataGridView.Columns["Reviews"].Visible = false;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            using (var context = new CinemaDatabase())
            {
                var query = from m in context.Movies
                            where m.MovieName.Contains(nameTextBox.Text)
                            select m;

                movieDataGridView.DataSource = null;
                movieDataGridView.DataSource = query.ToList();
                movieDataGridView.Columns["Movie_ID"].Visible = false;
                movieDataGridView.Columns["Reviews"].Visible = false;
            }
        }
        private void clearFilterBtn_Click(object sender, EventArgs e)
        {
            GetMovieData();
            nameTextBox.Text = String.Empty;
            genrComboBox.Text = String.Empty;
        }

        public Movy GetChosenMovie()
        {
            if (movieDataGridView.CurrentRow != null)
            {
                return movieDataGridView.CurrentRow.DataBoundItem as Movy;
            }
            else
            {
                MessageBox.Show("You need to select a movie");
                return null;
            }
        }

        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void ProfileLabel_Click(object sender, EventArgs e)
        {
            ProfileDisplay pd = new ProfileDisplay(activeUser);
            pd.ShowDialog();
        }

        private void AddMovieLabel_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovie = new AddMovieForm();
            addMovie.ShowDialog();

            if (addMovie.isFormUpdated())
            {
                GetMovieData();
            }
        }

        private void editMovieBtn_Click(object sender, EventArgs e)
        {
            Movy chosenMovie = GetChosenMovie();
            editMovieForm editMovieForm = new editMovieForm(chosenMovie);
            if (chosenMovie != null)
            {
                editMovieForm.ShowDialog();
            }
            GetMovieData();
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            SettingForms sf = new SettingForms();
            sf.ShowDialog();
            changeTheme();
        }
        private void changeTheme()
        {
            BackColor = GlobalVariable.principalColor;
            panel1.BackColor = GlobalVariable.SecondaryColor;
            movieDataGridView.BackgroundColor = GlobalVariable.principalColor;
            

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.Font = new Font(GlobalVariable.fontStyle, 10);
                    c.ForeColor = GlobalVariable.fontColor;
                    if (c.Name == "HomeLabel" || c.Name == "reservationLbl" || c.Name == "StatisticsLabel" || c.Name == "SettingsLabel" || c.Name == "AddMovieLabel" || c.Name == "ProfileLabel")
                    {
                        c.BackColor = GlobalVariable.SecondaryColor;
                    }
                }
                else if (c is Panel)
                {
                    foreach (Control cp in c.Controls)
                    {
                        if (cp is Label)
                        {
                            cp.Font = new Font(GlobalVariable.fontStyle, 10);
                            cp.ForeColor = GlobalVariable.fontColor;
                            cp.BackColor = GlobalVariable.SecondaryColor;
                        }

                    }
                }
            }

        }

        private void StatisticsLabel_Click(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new StatisticForm();
            statisticForm.ShowDialog();
        }
    }
}
