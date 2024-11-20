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
using System.Net;

namespace CinemaApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            bool exists = false;
            using (var context = new CinemaDatabase())
            {
                foreach (User item in context.Users)
                {
                    if ((item.Username == usernameTbx.Text && item.Username != "admin") && (item.Password == passwordTbx.Text && item.Password != "admin"))
                    {
                        exists = true;
                        usernameTbx.Text = string.Empty;
                        passwordTbx.Text = string.Empty;

                        MainForm mf = new MainForm(item);
                        this.Hide();
                        mf.ShowDialog();
                        break;
                    }
                    else if (usernameTbx.Text == "admin" && passwordTbx.Text == "admin")
                    {
                        exists = true;
                        AdminMainForm amf = new AdminMainForm(item);
                        this.Hide();
                        amf.ShowDialog();
                        break;
                    }
                    else if (usernameTbx.Text == string.Empty || passwordTbx.Text == string.Empty)
                    {
                        MessageBox.Show("You need to input your username and password");
                        break;
                    }
                }
                if (usernameTbx.Text != string.Empty && passwordTbx.Text != string.Empty && !exists)
                {
                    MessageBox.Show("Wrong Credentials");
                    passwordTbx.Text = string.Empty;
                }
            }
        }
        private void RecoveryButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            using (var context = new CinemaDatabase())
            {
                foreach (User item in context.Users)
                {
                    if (usernameTbx.Text == item.Username && usernameTbx.Text != string.Empty)
                    {
                        using (MailMessage mail = new MailMessage())
                        {
                            mail.From = new MailAddress("teampi2209@gmail.com");
                            mail.To.Add(item.Email);
                            mail.Subject = "Password recovery";
                            mail.Body = $"Thank you '{item.Username}' for using our recovery functionality." +
                            $" Below you can see your password in order to enter the application.\n" + "\n" +
                            $"Your password : {item.Password}" + "\n" + "\n" +
                            " Yours Sincerely, CinemaAPP team :)";
                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.Credentials = new NetworkCredential("teampi2209@gmail.com", "ruev vlsr ebaq onfj");
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                            }
                        }
                        MessageBox.Show("Password info has been succesfully sent to your email adress.");
                        found = true;
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Password info couldn't be sent. Please enter correct/valid username!");
                    usernameTbx.Text = string.Empty;
                    passwordTbx.Text = string.Empty;
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(LoginForm_KeyDown);

            RegisterButton.Cursor = Cursors.Hand;
            LogInButton.Cursor = Cursors.Hand;
            RecoveryButton.Cursor = Cursors.Hand;
            changeTheme();
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
                        c.Font = new Font(GlobalVariable.fontStyle, 48);
                        c.ForeColor = GlobalVariable.fontColor;

                    }
                    else if (c.Name == "label2")
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.ShowDialog();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (e.Handled)
                {
                    return;
                }
                HelpForm helpForm = new HelpForm();
                helpForm.ShowDialog();
                e.Handled = true;
            }
        }

        public override string ToString()
        {
            return "LoginForm";
        }
    }
}

