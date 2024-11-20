using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace CinemaApplication
{
    public partial class ReservationForm : Form
    {
        int reservationSuccessful = 0;
        User activeUser;
        private Movy chosenMovie;

        public ReservationForm(Movy ChosenMovie, User ActiveUser)
        {
            InitializeComponent();
            chosenMovie = ChosenMovie;
            activeUser = ActiveUser;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            movieNameTextBox.Text = chosenMovie.MovieName.ToString();
            GetCinemas();
            GetMovieHallsTime();
            ConnectTimeWithHall();
            GetDiscount();
            ReserveButton.Cursor = Cursors.Hand;
            CancelButton.Cursor = Cursors.Hand;
            changeTheme();
        }

        private void ConnectTimeWithHall()
        {
            var chosenTimeHall = timeComboBox.SelectedItem as MovieHall;
            movieHallTextBox.Text = chosenTimeHall.HallName;
        }

        private void GetMovieHallsTime()
        {
            List<MovieHall> movieHallsTimeTable;
            using (var context = new CinemaDatabase())
            {
                movieHallsTimeTable = context.MovieHalls.ToList();
            }
            timeComboBox.DataSource = movieHallsTimeTable;
        }

        private void GetCinemas()
        {
            List<Cinema> cinemas;
            using (var context = new CinemaDatabase())
            {
                cinemas = context.Cinemas.ToList();
            }
            cinemaComboBox.DataSource = cinemas;
        }

        private void timeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ConnectTimeWithHall();
            GetDiscount();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            if(ticketAmmComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please enter the number of tickets you want to reserve!");
            }
            else
            {
                using (var context = new CinemaDatabase())
                {
                    var query = from m in context.Movies
                                where m.MovieName == chosenMovie.MovieName
                                select m.NumberOfTickets;
                    int availableTicketAmount = int.Parse(query.ToList().FirstOrDefault().ToString());
                    //MessageBox.Show(availableTicketAmount.ToString());
                    if ((int.Parse(ticketAmmComboBox.SelectedItem.ToString())) > availableTicketAmount)
                    {
                        MessageBox.Show("There is not enough available seats for your request.\n " +
                            "Please choose a different number of tickets!");
                    }
                    else
                    {
                        reservationSuccessful = 1;
                        foreach (Movy item in context.Movies)
                        {
                            if (item.MovieName == movieNameTextBox.Text)
                            {
                                item.NumberOfTickets -= int.Parse(ticketAmmComboBox.SelectedItem.ToString());
                                context.Entry(item).Property(x => x.NumberOfTickets).IsModified = true;
                                break;
                            }
                        }
                        context.SaveChanges();
                        var query2 = from m in context.Movies where m.MovieName == chosenMovie.MovieName select m.NumberOfTickets;
                        int result = int.Parse(query2.ToList().FirstOrDefault().ToString());
                        MessageBox.Show($"Your reservation was successfull!\n Number of available tickets remaining : {result}.");
                    }
                    if (reservationSuccessful != 0)
                    {
                        Random rand = new Random();
                        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                        string characters =  new string(Enumerable.Repeat(chars, 10).Select(s => s[rand.Next(s.Length)]).ToArray());
                        double ticketPrice = 60;
                        double discount = double.Parse(discountTextBox.Text);
                        double pdv = 5;
                        double priceWithoutPDV = (double.Parse(ticketAmmComboBox.SelectedItem.ToString()) * ticketPrice) - ((double.Parse(ticketAmmComboBox.SelectedItem.ToString()) * ticketPrice) * (discount / 100));
                        double totalPrice = (priceWithoutPDV * (pdv / 100)) + priceWithoutPDV;
                        try
                        {
                            using (MailMessage mail = new MailMessage())
                            {
                                mail.From = new MailAddress("teampi2209@gmail.com");
                                mail.To.Add(activeUser.Email);
                                mail.Subject = "Billing details";
                                mail.Body = $"Thank you '{activeUser.Username}' for using our reservation functionality. " +
                                    $"Below you can see detailed billing info about your reservation : \n" + "\n" +
                                    $"Description: \n" + $"Movie name: {movieNameTextBox.Text} - {datePicker.Text.ToString()} {timeComboBox.SelectedItem.ToString()}\n"
                                    + $"Cinema name: {cinemaComboBox.SelectedItem.ToString()}\n" + 
                                    $"\nTicket/s info: \n" + $"Ticket ammount: {ticketAmmComboBox.SelectedItem.ToString()}\n" + 
                                    $"Ticket price: {ticketPrice} HRK\n" + $"PDV: {pdv} %\n"+ $"Total price (PDV and discount included): {totalPrice} HRK\n" + "\n" +
                                    $"Detailed billing info: \n" + $"Reservation time: {DateTime.Now}"+ "\n" + $"Ammount to pay: {totalPrice} HRK\n" +
                                    $"Type of payment: master\n" + $"Transaction ID: {rand.Next()}\n" + $"Authorization code: {rand.Next()}\n" + 
                                    $"Payment ID: {characters}\n";
                                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                                {
                                    smtp.Credentials = new NetworkCredential("teampi2209@gmail.com", "ruev vlsr ebaq onfj");
                                    smtp.EnableSsl = true;
                                    smtp.Send(mail);
                                }
                            }
                            MessageBox.Show("Billing info has been succesfully sent to your email adress.");
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Error with the reservation process, info mail couldn't have been sent. Please try again.");
                            this.Close();
                        }

                        try
                        {
                            using (MailMessage mail = new MailMessage())
                            {
                                mail.From = new MailAddress("teampi2209@gmail.com");
                                mail.To.Add(activeUser.Email);
                                mail.Subject = "Reservation details";
                                mail.Body = $"Thank you '{activeUser.Username}' for using our reservation functionality. Below you can see detailed info about your reservation : \n" +
                                "\n" + $" Movie name : {movieNameTextBox.Text}" + "\n" + $" Chosen cinema : {cinemaComboBox.SelectedItem.ToString()}" + "\n" +
                                $" Chosen date : {datePicker.Text.ToString()}" + "\n" + $" Chosen time and hall : {timeComboBox.SelectedItem.ToString()} at the {movieHallTextBox.Text} hall" + "\n" +
                                $" Number of tickets reserved : {ticketAmmComboBox.SelectedItem.ToString()}" + "\n" + "\n" + $"Please remember that your reservation is valid untill one hour before the start of the film!" + "\n" +
                                "Thank you and enjoy your movie!" + "\n" + "\n" + "CinemaAppTeam";
                                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                                {
                                    smtp.Credentials = new NetworkCredential("teampi2209@gmail.com", "ruev vlsr ebaq onfj");
                                    smtp.EnableSsl = true;
                                    smtp.Send(mail);
                                }
                            }
                            MessageBox.Show("Reservation info has been succesfully sent to your email adress.");
                            this.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error with the reservation process, info mail couldn't have been sent. Please try again.");
                            this.Close();
                        }
                    }
                }
            }
        }

        public void GetDiscount()
        {
            MovieHall mh = new MovieHall();
            mh = timeComboBox.SelectedItem as MovieHall;
            using (var context = new CinemaDatabase())
            {
                var query = from sd in context.SpecialDeals
                            where sd.MovieHalls_ID == mh.MovieHall_ID
                            select sd.Discount;
                discountTextBox.Text = query.ToList().FirstOrDefault().ToString();
            }
        }
        private void changeTheme()
        {
            this.BackColor = GlobalVariable.principalColor;
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.Font = new Font(GlobalVariable.fontStyle, 9);
                    c.ForeColor = GlobalVariable.fontColor;
                }
            }
        }
    }
}
