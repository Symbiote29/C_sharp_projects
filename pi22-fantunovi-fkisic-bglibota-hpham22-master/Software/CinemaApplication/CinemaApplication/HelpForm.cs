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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillData()
        {
            //var app = Application.OpenForms;
            foreach (var item in Application.OpenForms)
            {

                if (item.ToString() == "LoginForm")
                {
                    
                    TitleLabel.Text = "Login";
                    ContentLabel.Text = "You must enter your username and password in the given text boxes and \nthen click the 'Log in' button.\n" +
                        "\n If you forgot your password, don't worry. The option for you is \n the recover password button." +
                        "\n \n Still having problems ? You can always register to a new account :)";
                }
            }
        }
        private void HelpForm_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
