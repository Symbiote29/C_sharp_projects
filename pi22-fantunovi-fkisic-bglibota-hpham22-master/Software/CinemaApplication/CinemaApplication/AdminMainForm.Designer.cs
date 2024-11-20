namespace CinemaApplication
{
    partial class AdminMainForm
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
            this.clearFilterBtn = new System.Windows.Forms.Button();
            this.genrComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.StatisticsLabel = new System.Windows.Forms.Label();
            this.AddMovieLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.activeUserLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.editMovieBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearFilterBtn
            // 
            this.clearFilterBtn.Location = new System.Drawing.Point(662, 80);
            this.clearFilterBtn.Name = "clearFilterBtn";
            this.clearFilterBtn.Size = new System.Drawing.Size(103, 23);
            this.clearFilterBtn.TabIndex = 28;
            this.clearFilterBtn.Text = "Clear filter";
            this.clearFilterBtn.UseVisualStyleBackColor = true;
            this.clearFilterBtn.Click += new System.EventHandler(this.clearFilterBtn_Click);
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
            this.genrComboBox.Location = new System.Drawing.Point(499, 81);
            this.genrComboBox.Name = "genrComboBox";
            this.genrComboBox.Size = new System.Drawing.Size(122, 21);
            this.genrComboBox.TabIndex = 27;
            this.genrComboBox.SelectedIndexChanged += new System.EventHandler(this.genrComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(447, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Genre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(265, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(325, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(101, 20);
            this.nameTextBox.TabIndex = 24;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Location = new System.Drawing.Point(19, 121);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.RowHeadersWidth = 51;
            this.movieDataGridView.Size = new System.Drawing.Size(1159, 671);
            this.movieDataGridView.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "FEATURED MOVIES";
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.ProfileLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.ForeColor = System.Drawing.Color.White;
            this.ProfileLabel.Location = new System.Drawing.Point(481, 18);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(68, 16);
            this.ProfileLabel.TabIndex = 20;
            this.ProfileLabel.Text = "PROFILE";
            this.ProfileLabel.Click += new System.EventHandler(this.ProfileLabel_Click);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.SettingsLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsLabel.Location = new System.Drawing.Point(326, 18);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(76, 16);
            this.SettingsLabel.TabIndex = 19;
            this.SettingsLabel.Text = "SETTINGS";
            this.SettingsLabel.Click += new System.EventHandler(this.SettingsLabel_Click);
            // 
            // StatisticsLabel
            // 
            this.StatisticsLabel.AutoSize = true;
            this.StatisticsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.StatisticsLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsLabel.ForeColor = System.Drawing.Color.White;
            this.StatisticsLabel.Location = new System.Drawing.Point(164, 18);
            this.StatisticsLabel.Name = "StatisticsLabel";
            this.StatisticsLabel.Size = new System.Drawing.Size(90, 16);
            this.StatisticsLabel.TabIndex = 18;
            this.StatisticsLabel.Text = "STATISTICS";
            this.StatisticsLabel.Click += new System.EventHandler(this.StatisticsLabel_Click);
            // 
            // AddMovieLabel
            // 
            this.AddMovieLabel.AutoSize = true;
            this.AddMovieLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.AddMovieLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovieLabel.ForeColor = System.Drawing.Color.White;
            this.AddMovieLabel.Location = new System.Drawing.Point(20, 18);
            this.AddMovieLabel.Name = "AddMovieLabel";
            this.AddMovieLabel.Size = new System.Drawing.Size(89, 16);
            this.AddMovieLabel.TabIndex = 17;
            this.AddMovieLabel.Text = "ADD MOVIE";
            this.AddMovieLabel.Click += new System.EventHandler(this.AddMovieLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.activeUserLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.StatisticsLabel);
            this.panel1.Controls.Add(this.SettingsLabel);
            this.panel1.Controls.Add(this.ProfileLabel);
            this.panel1.Controls.Add(this.AddMovieLabel);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 52);
            this.panel1.TabIndex = 21;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1100, 18);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 15;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click_1);
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
            // editMovieBtn
            // 
            this.editMovieBtn.Location = new System.Drawing.Point(782, 79);
            this.editMovieBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editMovieBtn.Name = "editMovieBtn";
            this.editMovieBtn.Size = new System.Drawing.Size(106, 24);
            this.editMovieBtn.TabIndex = 21;
            this.editMovieBtn.Text = "Edit Movie";
            this.editMovieBtn.UseVisualStyleBackColor = true;
            this.editMovieBtn.Click += new System.EventHandler(this.editMovieBtn_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.editMovieBtn);
            this.Controls.Add(this.clearFilterBtn);
            this.Controls.Add(this.genrComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearFilterBtn;
        private System.Windows.Forms.ComboBox genrComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label StatisticsLabel;
        private System.Windows.Forms.Label AddMovieLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label activeUserLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button editMovieBtn;
    }
}