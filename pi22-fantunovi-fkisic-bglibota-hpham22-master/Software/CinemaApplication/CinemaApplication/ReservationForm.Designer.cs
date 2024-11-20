namespace CinemaApplication
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.cinemaComboBox = new System.Windows.Forms.ComboBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.ticketAmmComboBox = new System.Windows.Forms.ComboBox();
            this.movieHallTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.discountLbl = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cinema:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ticket amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time:";
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.Enabled = false;
            this.movieNameTextBox.Location = new System.Drawing.Point(240, 61);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(179, 22);
            this.movieNameTextBox.TabIndex = 5;
            // 
            // cinemaComboBox
            // 
            this.cinemaComboBox.FormattingEnabled = true;
            this.cinemaComboBox.Location = new System.Drawing.Point(240, 111);
            this.cinemaComboBox.Name = "cinemaComboBox";
            this.cinemaComboBox.Size = new System.Drawing.Size(179, 24);
            this.cinemaComboBox.TabIndex = 6;
            // 
            // timeComboBox
            // 
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(240, 222);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(179, 24);
            this.timeComboBox.TabIndex = 8;
            this.timeComboBox.SelectionChangeCommitted += new System.EventHandler(this.timeComboBox_SelectionChangeCommitted);
            // 
            // ticketAmmComboBox
            // 
            this.ticketAmmComboBox.FormattingEnabled = true;
            this.ticketAmmComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ticketAmmComboBox.Location = new System.Drawing.Point(240, 273);
            this.ticketAmmComboBox.Name = "ticketAmmComboBox";
            this.ticketAmmComboBox.Size = new System.Drawing.Size(179, 24);
            this.ticketAmmComboBox.TabIndex = 9;
            // 
            // movieHallTextBox
            // 
            this.movieHallTextBox.Enabled = false;
            this.movieHallTextBox.Location = new System.Drawing.Point(470, 224);
            this.movieHallTextBox.Name = "movieHallTextBox";
            this.movieHallTextBox.Size = new System.Drawing.Size(80, 22);
            this.movieHallTextBox.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(426, 370);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(124, 37);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(240, 370);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(124, 37);
            this.ReserveButton.TabIndex = 12;
            this.ReserveButton.Text = "Reserve ticket";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(240, 169);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(179, 22);
            this.datePicker.TabIndex = 13;
            // 
            // discountLbl
            // 
            this.discountLbl.AutoSize = true;
            this.discountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLbl.ForeColor = System.Drawing.Color.White;
            this.discountLbl.Location = new System.Drawing.Point(466, 249);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(86, 20);
            this.discountLbl.TabIndex = 14;
            this.discountLbl.Text = "Discount :";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Enabled = false;
            this.discountTextBox.Location = new System.Drawing.Point(470, 275);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(80, 22);
            this.discountTextBox.TabIndex = 15;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.discountLbl);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.movieHallTextBox);
            this.Controls.Add(this.ticketAmmComboBox);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.cinemaComboBox);
            this.Controls.Add(this.movieNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "Reserve the chosen ticket";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.ComboBox cinemaComboBox;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.ComboBox ticketAmmComboBox;
        private System.Windows.Forms.TextBox movieHallTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.TextBox discountTextBox;
    }
}