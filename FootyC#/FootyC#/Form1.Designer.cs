namespace FootyC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            registerButton = new Button();
            label1 = new Label();
            label2 = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label3 = new Label();
            passwordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(380, 304);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(84, 37);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(249, 304);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(84, 37);
            registerButton.TabIndex = 1;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 198);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 240);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(351, 237);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(351, 195);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(197, 67);
            label3.Name = "label3";
            label3.Size = new Size(309, 65);
            label3.TabIndex = 6;
            label3.Text = "FOOTY TIME";
            // 
            // passwordCheckBox
            // 
            passwordCheckBox.AutoSize = true;
            passwordCheckBox.Location = new Point(351, 266);
            passwordCheckBox.Name = "passwordCheckBox";
            passwordCheckBox.Size = new Size(55, 19);
            passwordCheckBox.TabIndex = 7;
            passwordCheckBox.Text = "Show";
            passwordCheckBox.UseVisualStyleBackColor = true;
            passwordCheckBox.CheckedChanged += passwordCheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 492);
            Controls.Add(passwordCheckBox);
            Controls.Add(label3);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Button registerButton;
        private Label label1;
        private Label label2;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label label3;
        private CheckBox passwordCheckBox;
    }
}
