using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie;
using Faq_DLL;

namespace CinemaApplication
{
    public partial class SettingForms : Form
    {
        public SettingForms()
        {
            InitializeComponent();
        }

        private void themeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (themeCheckbox.Checked)
            {
                GlobalVariable.principalColor = Color.FromArgb(255, 255, 255);
                GlobalVariable.SecondaryColor = Color.FromArgb(161, 206, 229);
                GlobalVariable.tertiaryColor = Color.FromArgb(172, 207, 225);
                GlobalVariable.fontColor = Color.FromArgb(0, 0, 0);
                GlobalVariable.lightTheme = true;

                AddMovieForm.primaryColor = GlobalVariable.principalColor;
                AddMovieForm.secondaryColor = GlobalVariable.SecondaryColor;
                AddMovieForm.fontColor = GlobalVariable.fontColor;
                AddMovieForm.fontStyle = GlobalVariable.fontStyle;

                GlobalVariableFaq.principalColor = GlobalVariable.principalColor;
                GlobalVariableFaq.SecondaryColor = GlobalVariable.SecondaryColor;
                GlobalVariableFaq.tertiaryColor = GlobalVariable.tertiaryColor;
                GlobalVariableFaq.fontColor = GlobalVariable.fontColor;
                GlobalVariableFaq.fontStyle = GlobalVariable.fontStyle;

                changeTheme();
            }
            else
            {
                GlobalVariable.principalColor = Color.FromArgb(13, 34, 61);
                GlobalVariable.SecondaryColor = Color.FromArgb(22, 54, 95);
                GlobalVariable.tertiaryColor = Color.FromArgb(45, 45, 60);
                GlobalVariable.fontColor = Color.FromArgb(255, 255, 255); 
                GlobalVariable.lightTheme = false;

                AddMovieForm.primaryColor = GlobalVariable.principalColor;
                AddMovieForm.secondaryColor = GlobalVariable.SecondaryColor;
                AddMovieForm.fontColor = GlobalVariable.fontColor;
                AddMovieForm.fontStyle = GlobalVariable.fontStyle;

                GlobalVariableFaq.principalColor = GlobalVariable.principalColor;
                GlobalVariableFaq.SecondaryColor = GlobalVariable.SecondaryColor;
                GlobalVariableFaq.tertiaryColor = GlobalVariable.tertiaryColor;
                GlobalVariableFaq.fontColor = GlobalVariable.fontColor;
                GlobalVariableFaq.fontStyle = GlobalVariable.fontStyle;

                changeTheme();
            }
        }

        private void SettingForms_Load(object sender, EventArgs e)
        {
            themeCheckbox.Checked = GlobalVariable.lightTheme;
            fontStyleCb.Text = GlobalVariable.fontStyle;
            changeTheme();
        }

        private void exitBtn_Click(object sender, EventArgs e)
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
                    c.Font = new Font(GlobalVariable.fontStyle, 12);
                    c.ForeColor = GlobalVariable.fontColor;
                }
                else if (c is CheckBox)
                {
                    c.Font = new Font(GlobalVariable.fontStyle, 12);
                    c.ForeColor = GlobalVariable.fontColor;
                }
            }

        }

        private void fontStyleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVariable.fontStyle = fontStyleCb.GetItemText(this.fontStyleCb.SelectedItem);
            changeTheme();
        }
    }
}
