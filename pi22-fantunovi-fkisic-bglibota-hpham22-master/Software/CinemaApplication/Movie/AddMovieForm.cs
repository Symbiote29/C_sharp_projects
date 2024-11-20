using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Movie
{
    public partial class AddMovieForm : Form
    {

        public static Color primaryColor = Color.FromArgb(13, 34, 61);
        public static Color secondaryColor = Color.FromArgb(22, 54, 95); 
        public static String fontStyle = "Microsoft Sans Serif";
        public static Color fontColor = Color.FromArgb(255, 255, 255);

        public AddMovieForm()
        {
            InitializeComponent();
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            using (var context = new CinemaDatabaseMovie())
            {
                string movieName = movieNameTextBox.Text;
                string director = directorTextBox.Text;
                string genre = genreComboBox.Text;
                string description = descriptionRichTextBox.Text;
                int duration = int.Parse(durationTextBox.Text);
                DateTime ReleaseDate = releaseDatePicker.Value.Date;
                DateTime ShownUntil = shownUntilDatePicker.Value.Date;

                Movies newMovie = new Movies()
                {
                    MovieName = movieName,
                    Director = director,
                    Genre = genre,
                    Description = description,
                    Duration = duration,
                    ReleaseDate = ReleaseDate,
                    ShownUntil = ShownUntil,
                    NumberOfTickets = 50
                };

                context.Movies.Add(newMovie);
                context.SaveChanges();
                MessageBox.Show("Movie is added to the database!");
                sendEmail(movieName, director, genre, description, duration, ReleaseDate, ShownUntil);
            }
            movieNameTextBox.Text = String.Empty;
            directorTextBox.Text = String.Empty;
            genreComboBox.Text = String.Empty;
            descriptionRichTextBox.Text = String.Empty;
            durationTextBox.Text = String.Empty;
            releaseDatePicker.Text = String.Empty;
            shownUntilDatePicker.Text = String.Empty;

            
            isFormUpdated();
        }

        private void sendEmail(string movieName, string director, string genre, string description, int duration, DateTime ReleaseDate, DateTime ShownUntil)
        {
            using (var context = new CinemaDatabaseMovie())
            {

                foreach(var item in context.Users)
                {
                    string to, from, pass, mail;
                    to = item.Email;
                    from = "filipantunovic29@gmail.com";
                    pass = "lleelqmvjbdqayqc";
                    mail = $"Hi {item.Username},\n" +
                        $"\n" +
                        $"Here u can see your movie reservation information:\n" +
                        $"\n" +
                        $"Movie name: {movieName}\n" +
                        $"Director: {director}\n" +
                        $"Genre: {genre}\n" +
                        $"Description: {description}\n" +
                        $"Duration: {duration.ToString()}\n" +
                        $"Release date: {ReleaseDate.Date.ToString()}\n" +
                        $"Shown until: {ShownUntil.Date.ToString()}\n" +
                        $"\n" +
                        $"Thank you for using our app and feel free to check out our new movie {movieName}\n" +
                        $"\n" +
                        $"Your CinemaApplication team";

                    MailMessage message = new MailMessage();
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = mail;
                    message.Subject = "New movie in Cinema!";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new System.Net.NetworkCredential(from, pass);
                    smtp.Send(message);
                }
                
            }
        }

        public bool isFormUpdated()
        {
            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeTheme()
        {

            this.BackColor = primaryColor;
            panel1.BackColor = secondaryColor;
            AddMovieLabel.Font = new Font(fontStyle, 15);
            AddMovieLabel.ForeColor = fontColor;
            AddMovieLabel.BackColor = secondaryColor;
            foreach (Control c in this.Controls)
            {
                if (c is Label) {
                    c.Font = new Font(fontStyle, 10);
                    c.ForeColor = fontColor;
                }
            }
        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            changeTheme();
        }
    }
}
