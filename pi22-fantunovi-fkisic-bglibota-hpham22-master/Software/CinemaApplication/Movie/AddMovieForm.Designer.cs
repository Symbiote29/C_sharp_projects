namespace Movie
{
    partial class AddMovieForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddMovieLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.releaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.shownUntilDatePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.AddMovieLabel);
            this.panel1.Location = new System.Drawing.Point(-8, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1591, 64);
            this.panel1.TabIndex = 24;
            // 
            // AddMovieLabel
            // 
            this.AddMovieLabel.AutoSize = true;
            this.AddMovieLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.AddMovieLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovieLabel.ForeColor = System.Drawing.Color.White;
            this.AddMovieLabel.Location = new System.Drawing.Point(44, 20);
            this.AddMovieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddMovieLabel.Name = "AddMovieLabel";
            this.AddMovieLabel.Size = new System.Drawing.Size(170, 29);
            this.AddMovieLabel.TabIndex = 23;
            this.AddMovieLabel.Text = "ADD MOVIE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Movie name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(487, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 447);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Release Date:";
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.Location = new System.Drawing.Point(1315, 740);
            this.addMovieBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(199, 57);
            this.addMovieBtn.TabIndex = 31;
            this.addMovieBtn.Text = "Add movie";
            this.addMovieBtn.UseVisualStyleBackColor = true;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.Location = new System.Drawing.Point(203, 140);
            this.movieNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.movieNameTextBox.TabIndex = 32;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(203, 220);
            this.directorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(207, 22);
            this.directorTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 512);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Shown Until:";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(203, 374);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(93, 22);
            this.durationTextBox.TabIndex = 35;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Fantasy",
            "Horror",
            "Mystery",
            "Romance",
            "Thriller",
            "Western"});
            this.genreComboBox.Location = new System.Drawing.Point(203, 295);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(207, 24);
            this.genreComboBox.TabIndex = 36;
            // 
            // releaseDatePicker
            // 
            this.releaseDatePicker.Location = new System.Drawing.Point(203, 447);
            this.releaseDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.releaseDatePicker.Name = "releaseDatePicker";
            this.releaseDatePicker.Size = new System.Drawing.Size(207, 22);
            this.releaseDatePicker.TabIndex = 37;
            // 
            // shownUntilDatePicker
            // 
            this.shownUntilDatePicker.Location = new System.Drawing.Point(203, 507);
            this.shownUntilDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shownUntilDatePicker.Name = "shownUntilDatePicker";
            this.shownUntilDatePicker.Size = new System.Drawing.Size(207, 22);
            this.shownUntilDatePicker.TabIndex = 38;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(609, 142);
            this.descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(600, 389);
            this.descriptionRichTextBox.TabIndex = 39;
            this.descriptionRichTextBox.Text = "";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(1073, 740);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(199, 57);
            this.cancelBtn.TabIndex = 40;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1571, 821);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.shownUntilDatePicker);
            this.Controls.Add(this.releaseDatePicker);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.movieNameTextBox);
            this.Controls.Add(this.addMovieBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1593, 872);
            this.MinimumSize = new System.Drawing.Size(1593, 872);
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            this.Load += new System.EventHandler(this.AddMovieForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddMovieLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.DateTimePicker releaseDatePicker;
        private System.Windows.Forms.DateTimePicker shownUntilDatePicker;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button cancelBtn;
    }
}