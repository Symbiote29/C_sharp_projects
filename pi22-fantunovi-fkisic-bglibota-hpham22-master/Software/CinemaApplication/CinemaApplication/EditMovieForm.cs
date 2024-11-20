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
    public partial class editMovieForm : Form
    {
        Movy chosenMovie = new Movy();
        public editMovieForm(Movy movie)
        {
            InitializeComponent();
            chosenMovie = movie;
        }

        private void updateMovieBtn_Click(object sender, EventArgs e) //Updating the movie information
        {
            if(DateTime.Compare(releaseDatedateTimePicker.Value, shownUntildateTimePicker.Value) >= 0)
            {
                MessageBox.Show("Please choose an appropriate date");
                releaseDatedateTimePicker.Value = chosenMovie.ReleaseDate;
                shownUntildateTimePicker.Value = chosenMovie.ShownUntil;
            }
            else
            {
                using (var context = new CinemaDatabase())
                {
                    if (chosenMovie != null)
                    {
                        var movie = context.Movies.SingleOrDefault(c => c.Movie_ID == chosenMovie.Movie_ID); //Fetch the movie data if the id is equal
                        if (movie != null) //If the movie exist this will modify every data for the selected movie
                        {
                            movie.MovieName = movieNameTb.Text;
                            movie.Director = directorTb.Text;
                            movie.Genre = genreTb.Text;
                            movie.Description = descriptionTb.Text;
                            movie.Duration = Int32.Parse(durationTb.Text);
                            movie.ReleaseDate = DateTime.Parse(releaseDatedateTimePicker.Text);
                            movie.ShownUntil = DateTime.Parse(shownUntildateTimePicker.Text);
                            context.SaveChanges();
                        }
                    }
                };
                this.Close();
            }
            
        }

        private void editMovieForm_Load(object sender, EventArgs e) //Preload the edit form with the movie data selected
        {
            if (chosenMovie != null)
            {
                movieNameTb.Text = chosenMovie.MovieName;
                directorTb.Text = chosenMovie.Director;
                genreTb.Text = chosenMovie.Genre;
                descriptionTb.Text = chosenMovie.Description;
                durationTb.Text = chosenMovie.Duration.ToString();
                releaseDatedateTimePicker.Value = chosenMovie.ReleaseDate;
                shownUntildateTimePicker.Value = chosenMovie.ShownUntil;
            }
            changeTheme();
        }

        private void cancelButton_Click(object sender, EventArgs e) //Cancel the action and close the form
        {
            this.Close();
        }

        private void changeTheme()
        {
            BackColor = GlobalVariable.principalColor;
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.Font = new Font(GlobalVariable.fontStyle, 8);
                    c.ForeColor = GlobalVariable.fontColor;
                }
            }
            //cancelButton.Font = new Font(GlobalVariable.fontStyle, 8);
            //updateMovieBtn.Font = new Font(GlobalVariable.fontStyle, 8);
        }

    }
}
