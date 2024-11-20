using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faq_DLL
{
    public partial class FaqForm : Form
    {
        private Form activeForm;

        public FaqForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(childForm);
            this.ContainerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleLabel.Text = childForm.Text;

        }

        private void FaqLogInButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Faq_LogInForm(), sender);
        }

        private void FaqRegistrationButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Faq_RegistrationForm(), sender);
        }

        private void FaqReservationsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Faq_ReservationForm(), sender);
        }

        private void FaqPricingButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Faq_PricingForm(), sender);
        }

        private void FaqProfileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Faq_ProfileForm(), sender);
        }

        private void FaqForm_Load(object sender, EventArgs e)
        {
            FaqLogInButton.Cursor = Cursors.Hand;
            FaqRegistrationButton.Cursor = Cursors.Hand;
            FaqReservationsButton.Cursor = Cursors.Hand;
            FaqProfileButton.Cursor = Cursors.Hand;
            FaqPricingButton.Cursor = Cursors.Hand;
            HomeLabel.Cursor = Cursors.Hand;
            changeTheme();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void changeTheme()
        {
            panelLogo.BackColor = GlobalVariableFaq.SecondaryColor;
            HomeLabel.Font = new Font(GlobalVariableFaq.fontStyle, 13);
            HomeLabel.ForeColor = GlobalVariableFaq.fontColor;
            

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    if (c.Name == "label4")
                    {
                        c.Font = new Font(GlobalVariableFaq.fontStyle, 12, FontStyle.Bold);
                        c.ForeColor = GlobalVariableFaq.fontColor;
                    }
                    else
                    {
                        c.Font = new Font(GlobalVariableFaq.fontStyle, 10);
                        c.ForeColor = GlobalVariableFaq.fontColor;
                    }
                }
                else if(c is Panel)
                {
                    if(c.Name == "ContainerPanel")
                    {
                        c.BackColor = GlobalVariableFaq.principalColor;
                        foreach (Control cp in c.Controls)
                        {
                            if (cp is Label)
                            {

                                if (cp.Name == "label4")
                                {
                                    cp.Font = new Font(GlobalVariableFaq.fontStyle, 12, FontStyle.Bold);
                                    cp.ForeColor = GlobalVariableFaq.fontColor;
                                }
                                else
                                {
                                    cp.Font = new Font(GlobalVariableFaq.fontStyle, 10);
                                    cp.ForeColor = GlobalVariableFaq.fontColor;
                                }
                            }
                        }
                    }else if (c.Name == "panelMenu")
                    {
                        c.BackColor = GlobalVariableFaq.tertiaryColor;
                    }
                    else
                    {
                        c.BackColor = GlobalVariableFaq.SecondaryColor;
                        foreach (Control cp in c.Controls)
                        {
                            if (cp is Label)
                            {
                                    cp.Font = new Font(GlobalVariableFaq.fontStyle, 10);
                                    cp.ForeColor = GlobalVariableFaq.fontColor;
                            }
                        }
                    }
                }
            }
            FaqLogInButton.BackColor = GlobalVariableFaq.tertiaryColor;
            FaqLogInButton.Font = new Font(GlobalVariableFaq.fontStyle, 10);
            FaqLogInButton.ForeColor = GlobalVariableFaq.fontColor;

            FaqRegistrationButton.BackColor = GlobalVariableFaq.tertiaryColor;
            FaqRegistrationButton.Font = new Font(GlobalVariableFaq.fontStyle, 10);
            FaqRegistrationButton.ForeColor = GlobalVariableFaq.fontColor;

            FaqReservationsButton.BackColor = GlobalVariableFaq.tertiaryColor;
            FaqReservationsButton.Font = new Font(GlobalVariableFaq.fontStyle, 10);
            FaqReservationsButton.ForeColor = GlobalVariableFaq.fontColor;

            FaqProfileButton.BackColor = GlobalVariableFaq.tertiaryColor;
            FaqProfileButton.Font = new Font(GlobalVariableFaq.fontStyle, 10);
            FaqProfileButton.ForeColor = GlobalVariableFaq.fontColor;

            FaqPricingButton.BackColor = GlobalVariableFaq.tertiaryColor;
            FaqPricingButton.Font = new Font(GlobalVariableFaq.fontStyle, 10);
            FaqPricingButton.ForeColor = GlobalVariableFaq.fontColor;



        }
    }
}
