﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faq_DLL.Forms
{
    public partial class Faq_ReservationForm : Form
    {
        public Faq_ReservationForm()
        {
            InitializeComponent();
        }

        private void Faq_ReservationForm_Load(object sender, EventArgs e)
        {
            changeTheme();
        }

        private void changeTheme()
        {
            this.BackColor = GlobalVariableFaq.principalColor;
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    if (c.Name == "label1" || c.Name == "label4" || c.Name == "label7")
                    {
                        c.Font = new Font(GlobalVariableFaq.fontStyle, 12, FontStyle.Bold);
                        c.ForeColor = GlobalVariableFaq.fontColor;
                    }
                    else
                    {
                        c.Font = new Font(GlobalVariableFaq.fontStyle, 9);
                        c.ForeColor = GlobalVariableFaq.fontColor;

                    }

                }
            }
        }
    }
}
