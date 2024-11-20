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
    public partial class ReviewForm : Form
    {
        Movy selectedMovie;
        User currentUser;
       
        public ReviewForm(Movy chosenMovie, User _currentUser)
        {
            InitializeComponent();
            selectedMovie = chosenMovie;
            currentUser = _currentUser;
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            movieNameLabel.Text = selectedMovie.MovieName;
            GetReviews();
            changeTheme();
        }

        public void GetReviews()
        {
            reviewDataGrid.DataSource = GetAllReviews();
            reviewDataGrid.Columns["Review_ID"].Visible = false;
            reviewDataGrid.Columns["Movie_ID"].Visible = false;
            reviewDataGrid.Columns["Movy"].Visible = false;
            reviewDataGrid.Columns[3].Width = 510;     
        }

        private object GetAllReviews()
        {
            using(var context = new CinemaDatabase())
            {
                var query = from r in context.Reviews
                            where r.Movie_ID == selectedMovie.Movie_ID
                            select r;

                return query.ToList();
            }
        }

        private void addReviewBtn_Click(object sender, EventArgs e)
        {
            AddReviewForm addReviewForm = new AddReviewForm(this, selectedMovie, currentUser);
            addReviewForm.ShowDialog();
        }

        private Review getReview()
        {
            try
            {
                return reviewDataGrid.CurrentRow.DataBoundItem as Review;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You need to select review first!");
                return null;
            }
        }

        private void editReviewBtn_Click(object sender, EventArgs e)
        {
            var selectedReview = getReview();
            if(selectedReview != null)
            {
                using (var context = new CinemaDatabase())
                {
                    if (currentUser.Username == selectedReview.Username)
                    {
                        EditReviewForm editReviewForm = new EditReviewForm(selectedReview, this);
                        editReviewForm.ShowDialog();
                    }
                    else MessageBox.Show("You must be owner of that review to be able to edit it!");
                }
            }   
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteReviewBtn_Click(object sender, EventArgs e)
        {
            var selectedReview = getReview();
            if (selectedReview != null)
            {
                using (var context = new CinemaDatabase())
                {
                    if (currentUser.Username == selectedReview.Username)
                    {
                        context.Reviews.Attach(selectedReview);
                        context.Reviews.Remove(selectedReview);
                        MessageBox.Show("Review deleted successfully");
                        context.SaveChanges();
                    }
                    else MessageBox.Show("You must be owner of that review to be able to delete it!");
                    GetReviews();
                }
            }

        }

        private void changeTheme()
        {
            BackColor = GlobalVariable.principalColor;

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.Font = new Font(GlobalVariable.fontStyle, 15);
                    c.ForeColor = GlobalVariable.fontColor;
                }
            }

        }
    }
}
