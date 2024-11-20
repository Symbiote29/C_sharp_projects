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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            bool exists = false;
            using (var context = new CinemaDatabase())
            {
                foreach (User item in context.Users)
                {
                    if (item.Username.Equals(usernameTextBox.Text))
                    {
                        exists = true;
                        MessageBox.Show("User with those credentials already exists");
                        firstNameTextBox.Text = string.Empty;
                        lastNameTextBox.Text = string.Empty;
                        usernameTextBox.Text = string.Empty;
                        passwordTextBox.Text = string.Empty;
                        emailTextBox.Text = string.Empty;
                        phoneNumberTextBox.Text = string.Empty;
                        break;
                    }
                }
                if (!exists)
                {
                    string FirstName = firstNameTextBox.Text;
                    string LastName = lastNameTextBox.Text;
                    string Username = usernameTextBox.Text;
                    string Password = passwordTextBox.Text;
                    string Email = emailTextBox.Text;
                    string PhoneNumber = phoneNumberTextBox.Text;

                    User user = new User()
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        Username = Username,
                        Password = Password,
                        Email = Email,
                        PhoneNumber = PhoneNumber,
                    };

                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Registration Sucessful");
                    firstNameTextBox.Text = string.Empty;
                    lastNameTextBox.Text = string.Empty;
                    usernameTextBox.Text = string.Empty;
                    passwordTextBox.Text = string.Empty;
                    emailTextBox.Text = string.Empty;
                    phoneNumberTextBox.Text = string.Empty;
                }
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            backToLoginBtn.Cursor = Cursors.Hand;
            registerBtn.Cursor = Cursors.Hand;
            changeTheme();
        }

        public void changeTheme()
        {
            BackColor = GlobalVariable.principalColor;
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    
                    if(c.Name == "label8")
                    {
                        c.Font = new Font(GlobalVariable.fontStyle, 48);
                        c.ForeColor = GlobalVariable.fontColor;
                    }
                    else if(c.Name == "label3")
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
    }
}
