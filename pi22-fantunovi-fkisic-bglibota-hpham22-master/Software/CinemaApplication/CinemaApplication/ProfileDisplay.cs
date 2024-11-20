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
    public partial class ProfileDisplay : Form
    {
        User chosenUser;
        public ProfileDisplay(User user)
        {
            InitializeComponent();
            chosenUser = user;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfileDisplay_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = chosenUser.Username;
            firstNameTextBox.Text = chosenUser.FirstName;
            lastNameTextBox.Text = chosenUser.LastName;
            passwordTextBox.Text = "*******";
            emailTextBox.Text = chosenUser.Email;
            phoneNumberTextBox.Text = chosenUser.PhoneNumber;
            changeTheme();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = chosenUser.Password;
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
            label6.BackColor = GlobalVariable.SecondaryColor;
        }
    }
}
