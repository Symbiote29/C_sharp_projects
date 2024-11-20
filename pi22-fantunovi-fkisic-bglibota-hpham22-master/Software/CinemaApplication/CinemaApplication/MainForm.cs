using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faq_DLL;

namespace CinemaApplication
{
    public partial class MainForm : Form
    {
        User activeUser;
        public MainForm(User user)
        {
            InitializeComponent();
            activeUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetMovieData();
            activeUserLabel.Text = activeUser.Username;
            SettingsLabel.Cursor = Cursors.Hand;
            ProfileLabel.Cursor = Cursors.Hand;
            logOutButton.Cursor = Cursors.Hand;
            clearFilterBtn.Cursor = Cursors.Hand;
            ReserveButton.Cursor = Cursors.Hand;
            FAQLabel.Cursor = Cursors.Hand;
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

        private void label6_Click(object sender, EventArgs e)
        {
            ProfileDisplay pd = new ProfileDisplay(activeUser);
            pd.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
        private Movy GetChosenMovie()
        {
            try
            {
                return movieDataGridView.CurrentRow.DataBoundItem as Movy;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You need to select a certain movie in order to continue !");
                return null;
            }
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            var chosenMovie = GetChosenMovie();
            if (chosenMovie != null)
            {
                ReservationForm reservationForm = new ReservationForm(chosenMovie,activeUser);
                reservationForm.ShowDialog();
                GetMovieData();
            }
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
                    if (c.Name == "SettingsLabel" || c.Name == "ProfileLabel" )
                    {
                        c.BackColor = GlobalVariable.SecondaryColor;
                    }
                }else if(c is Panel)
                {
                    foreach(Control cp in c.Controls)
                    {
                        if(cp is Label)
                        {
                            cp.Font = new Font(GlobalVariable.fontStyle, 10);
                            cp.ForeColor = GlobalVariable.fontColor;
                            cp.BackColor = GlobalVariable.SecondaryColor;
                        }
                        
                    }
                }
                
            }

        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            var chosenMovie = GetChosenMovie();
            if(chosenMovie != null)
            {
                ReviewForm reviewForm = new ReviewForm(chosenMovie, activeUser);
                reviewForm.ShowDialog();
            }
            
        }

        private void FAQLabel_Click(object sender, EventArgs e)
        {
            FaqForm faqForm = new FaqForm();
            faqForm.ShowDialog();
        }
    }
}
