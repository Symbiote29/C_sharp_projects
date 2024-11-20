namespace FootyC_
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            firstnameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            dateOfBirth = new DateTimePicker();
            registerButton = new Button();
            passwordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(85, 37);
            label1.Name = "label1";
            label1.Size = new Size(214, 30);
            label1.TabIndex = 0;
            label1.Text = "Register your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 109);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Ime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 152);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Prezime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 191);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Korisnicko ime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 233);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "Lozinka";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 297);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 5;
            label6.Text = "Godina rodenja";
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.Location = new Point(199, 106);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(120, 23);
            firstnameTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(199, 149);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(120, 23);
            surnameTextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(199, 191);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(120, 23);
            usernameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(199, 230);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(120, 23);
            passwordTextBox.TabIndex = 9;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Location = new Point(199, 291);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(120, 23);
            dateOfBirth.TabIndex = 10;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(151, 350);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(93, 37);
            registerButton.TabIndex = 11;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordCheckBox
            // 
            passwordCheckBox.AutoSize = true;
            passwordCheckBox.Location = new Point(199, 258);
            passwordCheckBox.Name = "passwordCheckBox";
            passwordCheckBox.Size = new Size(55, 19);
            passwordCheckBox.TabIndex = 12;
            passwordCheckBox.Text = "Show";
            passwordCheckBox.UseVisualStyleBackColor = true;
            passwordCheckBox.CheckedChanged += passwordCheckBox_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 443);
            Controls.Add(passwordCheckBox);
            Controls.Add(registerButton);
            Controls.Add(dateOfBirth);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(firstnameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox firstnameTextBox;
        private TextBox surnameTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private DateTimePicker dateOfBirth;
        private Button registerButton;
        private CheckBox passwordCheckBox;
    }
}