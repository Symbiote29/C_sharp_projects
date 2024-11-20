namespace CinemaApplication
{
    partial class MainForm
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
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FAQLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.activeUserLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.genrComboBox = new System.Windows.Forms.ComboBox();
            this.clearFilterBtn = new System.Windows.Forms.Button();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.reviewBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.SettingsLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsLabel.Location = new System.Drawing.Point(20, 18);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(76, 16);
            this.SettingsLabel.TabIndex = 4;
            this.SettingsLabel.Text = "SETTINGS";
            this.SettingsLabel.Click += new System.EventHandler(this.SettingsLabel_Click);
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.ProfileLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.ForeColor = System.Drawing.Color.White;
            this.ProfileLabel.Location = new System.Drawing.Point(134, 18);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(68, 16);
            this.ProfileLabel.TabIndex = 5;
            this.ProfileLabel.Text = "PROFILE";
            this.ProfileLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.FAQLabel);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.activeUserLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.SettingsLabel);
            this.panel1.Controls.Add(this.ProfileLabel);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 52);
            this.panel1.TabIndex = 6;
            // 
            // FAQLabel
            // 
            this.FAQLabel.AutoSize = true;
            this.FAQLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.FAQLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAQLabel.ForeColor = System.Drawing.Color.White;
            this.FAQLabel.Location = new System.Drawing.Point(245, 18);
            this.FAQLabel.Name = "FAQLabel";
            this.FAQLabel.Size = new System.Drawing.Size(37, 16);
            this.FAQLabel.TabIndex = 17;
            this.FAQLabel.Text = "FAQ";
            this.FAQLabel.Click += new System.EventHandler(this.FAQLabel_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1100, 18);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 15;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // activeUserLabel
            // 
            this.activeUserLabel.AutoSize = true;
            this.activeUserLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserLabel.ForeColor = System.Drawing.Color.White;
            this.activeUserLabel.Location = new System.Drawing.Point(1024, 22);
            this.activeUserLabel.Name = "activeUserLabel";
            this.activeUserLabel.Size = new System.Drawing.Size(36, 14);
            this.activeUserLabel.TabIndex = 16;
            this.activeUserLabel.Text = "user";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(975, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "FEATURED MOVIES";
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Location = new System.Drawing.Point(16, 120);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.RowHeadersWidth = 51;
            this.movieDataGridView.Size = new System.Drawing.Size(877, 545);
            this.movieDataGridView.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(322, 82);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(262, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(444, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Genre:";
            // 
            // genrComboBox
            // 
            this.genrComboBox.FormattingEnabled = true;
            this.genrComboBox.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Fantasy",
            "Horror",
            "Mystery",
            "Romance",
            "Thriller",
            "Western"});
            this.genrComboBox.Location = new System.Drawing.Point(496, 80);
            this.genrComboBox.Name = "genrComboBox";
            this.genrComboBox.Size = new System.Drawing.Size(121, 21);
            this.genrComboBox.TabIndex = 13;
            this.genrComboBox.SelectedIndexChanged += new System.EventHandler(this.genrComboBox_SelectedIndexChanged);
            // 
            // clearFilterBtn
            // 
            this.clearFilterBtn.Location = new System.Drawing.Point(659, 79);
            this.clearFilterBtn.Name = "clearFilterBtn";
            this.clearFilterBtn.Size = new System.Drawing.Size(102, 23);
            this.clearFilterBtn.TabIndex = 14;
            this.clearFilterBtn.Text = "Clear filter";
            this.clearFilterBtn.UseVisualStyleBackColor = true;
            this.clearFilterBtn.Click += new System.EventHandler(this.clearFilterBtn_Click);
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(1020, 139);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(126, 44);
            this.ReserveButton.TabIndex = 15;
            this.ReserveButton.Text = "Reserve a ticket";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // reviewBtn
            // 
            this.reviewBtn.Location = new System.Drawing.Point(1020, 215);
            this.reviewBtn.Name = "reviewBtn";
            this.reviewBtn.Size = new System.Drawing.Size(126, 48);
            this.reviewBtn.TabIndex = 16;
            this.reviewBtn.Text = "View review";
            this.reviewBtn.UseVisualStyleBackColor = true;
            this.reviewBtn.Click += new System.EventHandler(this.reviewBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1180, 677);
            this.Controls.Add(this.reviewBtn);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.clearFilterBtn);
            this.Controls.Add(this.genrComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CinemaApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox genrComboBox;
        private System.Windows.Forms.Button clearFilterBtn;
        private System.Windows.Forms.Label activeUserLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Button reviewBtn;
        private System.Windows.Forms.Label FAQLabel;
    }
}