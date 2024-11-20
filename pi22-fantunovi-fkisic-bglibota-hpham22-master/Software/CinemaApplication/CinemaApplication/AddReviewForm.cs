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
    public partial class AddReviewForm : Form
    {
        ReviewForm reviewForm;
        Movy selectedMovie;
        User currentUser;
        public AddReviewForm(ReviewForm _reviewForm, Movy _selectedMovie, User _currentUser)
        {
            InitializeComponent();
            reviewForm = _reviewForm;
            selectedMovie = _selectedMovie;
            currentUser = _currentUser;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            using(var context = new CinemaDatabase())
            {
                int rating = int.Parse(ratingComboBox.Text);
                string feedback = feedbackRichTextBox.Text;

                Review newReview = new Review
                {
                    Username = currentUser.Username,
                    Rating = rating,
                    Feedback = feedback,
                    Movie_ID = selectedMovie.Movie_ID
                };

                context.Reviews.Add(newReview);
                context.SaveChanges();

                reviewForm.GetReviews();

                MessageBox.Show("Review added successfully!");

                this.Close();
            }
        }

        private void changeTheme()
        {
            BackColor = GlobalVariable.principalColor;

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    if(c.Name == "label1")
                    {
                        c.Font = new Font(GlobalVariable.fontStyle, 15);
                        c.ForeColor = GlobalVariable.fontColor;
                    }
                    else
                    {
                        c.Font = new Font(GlobalVariable.fontStyle, 10);
                        c.ForeColor = GlobalVariable.fontColor;
                    }
                    
                }
            }

        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {
            changeTheme();
        }
    }
}
