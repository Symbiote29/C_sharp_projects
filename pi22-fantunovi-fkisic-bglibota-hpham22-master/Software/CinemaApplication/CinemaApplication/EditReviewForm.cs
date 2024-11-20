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
    public partial class EditReviewForm : Form
    {
        Review selectedReview;
        ReviewForm reviewForm;
        public EditReviewForm(Review _selectedReview, ReviewForm _reviewForm)
        {
            InitializeComponent();
            selectedReview = _selectedReview;
            reviewForm = _reviewForm;
        }

        private void EditReviewForm_Load(object sender, EventArgs e)
        {
            ratingComboBox.Text = selectedReview.Rating.ToString();
            feedbackRichTextBox.Text = selectedReview.Feedback.ToString();
            changeTheme();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            using (var context = new CinemaDatabase())
            {
                context.Reviews.Attach(selectedReview);
                selectedReview.Rating = int.Parse(ratingComboBox.Text);
                selectedReview.Feedback = feedbackRichTextBox.Text;
                context.SaveChanges();
            }

            MessageBox.Show("Review edited!");
            reviewForm.GetReviews();

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
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
                    if (c.Name == "label1")
                    {
                        c.Font = new Font(GlobalVariable.fontStyle, 16);
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
    }
}
