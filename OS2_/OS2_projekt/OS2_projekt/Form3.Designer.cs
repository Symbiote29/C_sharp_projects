namespace OS2_projekt
{
    partial class Form3
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
            this.backButton = new System.Windows.Forms.Button();
            this.afterTextBox2 = new System.Windows.Forms.TextBox();
            this.beforeTextBox2 = new System.Windows.Forms.TextBox();
            this.plainTextBox2 = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.symetricAlgorithms = new System.Windows.Forms.ComboBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.openDecryptButton = new System.Windows.Forms.Button();
            this.symDecryptTextBox = new System.Windows.Forms.TextBox();
            this.calculateHashButton = new System.Windows.Forms.Button();
            this.hashTextBox2 = new System.Windows.Forms.TextBox();
            this.chosenPasswordTextBox = new System.Windows.Forms.TextBox();
            this.choosePasswordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordButton = new System.Windows.Forms.Button();
            this.generatePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(665, 764);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 48);
            this.backButton.TabIndex = 28;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // afterTextBox2
            // 
            this.afterTextBox2.Location = new System.Drawing.Point(384, 313);
            this.afterTextBox2.Multiline = true;
            this.afterTextBox2.Name = "afterTextBox2";
            this.afterTextBox2.Size = new System.Drawing.Size(297, 54);
            this.afterTextBox2.TabIndex = 27;
            // 
            // beforeTextBox2
            // 
            this.beforeTextBox2.Location = new System.Drawing.Point(43, 549);
            this.beforeTextBox2.Multiline = true;
            this.beforeTextBox2.Name = "beforeTextBox2";
            this.beforeTextBox2.Size = new System.Drawing.Size(297, 81);
            this.beforeTextBox2.TabIndex = 26;
            // 
            // plainTextBox2
            // 
            this.plainTextBox2.Location = new System.Drawing.Point(43, 313);
            this.plainTextBox2.Multiline = true;
            this.plainTextBox2.Name = "plainTextBox2";
            this.plainTextBox2.Size = new System.Drawing.Size(297, 54);
            this.plainTextBox2.TabIndex = 25;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(7, 31);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(121, 20);
            this.pathTextBox.TabIndex = 24;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(134, 21);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(107, 38);
            this.uploadButton.TabIndex = 23;
            this.uploadButton.Text = "Upload .txt file";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // symetricAlgorithms
            // 
            this.symetricAlgorithms.FormattingEnabled = true;
            this.symetricAlgorithms.Items.AddRange(new object[] {
            "AES-128",
            "AES-192",
            "AES-256"});
            this.symetricAlgorithms.Location = new System.Drawing.Point(299, 81);
            this.symetricAlgorithms.Name = "symetricAlgorithms";
            this.symetricAlgorithms.Size = new System.Drawing.Size(121, 21);
            this.symetricAlgorithms.TabIndex = 22;
            this.symetricAlgorithms.Text = "AES-128";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(504, 256);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 37);
            this.decryptButton.TabIndex = 20;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click_1);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(153, 255);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 38);
            this.encryptButton.TabIndex = 19;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click_1);
            // 
            // openDecryptButton
            // 
            this.openDecryptButton.Location = new System.Drawing.Point(482, 21);
            this.openDecryptButton.Name = "openDecryptButton";
            this.openDecryptButton.Size = new System.Drawing.Size(107, 37);
            this.openDecryptButton.TabIndex = 38;
            this.openDecryptButton.Text = "Upload file to decrypt";
            this.openDecryptButton.UseVisualStyleBackColor = true;
            this.openDecryptButton.Click += new System.EventHandler(this.openDecryptButton_Click);
            // 
            // symDecryptTextBox
            // 
            this.symDecryptTextBox.Location = new System.Drawing.Point(384, 549);
            this.symDecryptTextBox.Multiline = true;
            this.symDecryptTextBox.Name = "symDecryptTextBox";
            this.symDecryptTextBox.Size = new System.Drawing.Size(297, 81);
            this.symDecryptTextBox.TabIndex = 39;
            // 
            // calculateHashButton
            // 
            this.calculateHashButton.Location = new System.Drawing.Point(153, 650);
            this.calculateHashButton.Name = "calculateHashButton";
            this.calculateHashButton.Size = new System.Drawing.Size(75, 37);
            this.calculateHashButton.TabIndex = 40;
            this.calculateHashButton.Text = "Calculate hash";
            this.calculateHashButton.UseVisualStyleBackColor = true;
            this.calculateHashButton.Click += new System.EventHandler(this.calculateHashButton_Click);
            // 
            // hashTextBox2
            // 
            this.hashTextBox2.Location = new System.Drawing.Point(43, 716);
            this.hashTextBox2.Multiline = true;
            this.hashTextBox2.Name = "hashTextBox2";
            this.hashTextBox2.Size = new System.Drawing.Size(297, 60);
            this.hashTextBox2.TabIndex = 41;
            // 
            // chosenPasswordTextBox
            // 
            this.chosenPasswordTextBox.Location = new System.Drawing.Point(384, 449);
            this.chosenPasswordTextBox.Name = "chosenPasswordTextBox";
            this.chosenPasswordTextBox.Size = new System.Drawing.Size(297, 20);
            this.chosenPasswordTextBox.TabIndex = 42;
            // 
            // choosePasswordButton
            // 
            this.choosePasswordButton.Location = new System.Drawing.Point(482, 388);
            this.choosePasswordButton.Name = "choosePasswordButton";
            this.choosePasswordButton.Size = new System.Drawing.Size(107, 37);
            this.choosePasswordButton.TabIndex = 43;
            this.choosePasswordButton.Text = "Choose password for decryption";
            this.choosePasswordButton.UseVisualStyleBackColor = true;
            this.choosePasswordButton.Click += new System.EventHandler(this.choosePasswordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(43, 449);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(297, 20);
            this.passwordTextBox.TabIndex = 44;
            // 
            // confirmPasswordButton
            // 
            this.confirmPasswordButton.Location = new System.Drawing.Point(134, 388);
            this.confirmPasswordButton.Name = "confirmPasswordButton";
            this.confirmPasswordButton.Size = new System.Drawing.Size(110, 37);
            this.confirmPasswordButton.TabIndex = 45;
            this.confirmPasswordButton.Text = "Choose password for encryption";
            this.confirmPasswordButton.UseVisualStyleBackColor = true;
            this.confirmPasswordButton.Click += new System.EventHandler(this.confirmPasswordButton_Click);
            // 
            // generatePassword
            // 
            this.generatePassword.Location = new System.Drawing.Point(299, 147);
            this.generatePassword.Name = "generatePassword";
            this.generatePassword.Size = new System.Drawing.Size(121, 47);
            this.generatePassword.TabIndex = 46;
            this.generatePassword.Text = "Generate secret key";
            this.generatePassword.UseVisualStyleBackColor = true;
            this.generatePassword.Click += new System.EventHandler(this.generatePassword_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 853);
            this.Controls.Add(this.generatePassword);
            this.Controls.Add(this.confirmPasswordButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.choosePasswordButton);
            this.Controls.Add(this.chosenPasswordTextBox);
            this.Controls.Add(this.hashTextBox2);
            this.Controls.Add(this.calculateHashButton);
            this.Controls.Add(this.symDecryptTextBox);
            this.Controls.Add(this.openDecryptButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.afterTextBox2);
            this.Controls.Add(this.beforeTextBox2);
            this.Controls.Add(this.plainTextBox2);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.symetricAlgorithms);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox afterTextBox2;
        private System.Windows.Forms.TextBox beforeTextBox2;
        private System.Windows.Forms.TextBox plainTextBox2;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.ComboBox symetricAlgorithms;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button openDecryptButton;
        private System.Windows.Forms.TextBox symDecryptTextBox;
        private System.Windows.Forms.Button calculateHashButton;
        private System.Windows.Forms.TextBox hashTextBox2;
        private System.Windows.Forms.TextBox chosenPasswordTextBox;
        private System.Windows.Forms.Button choosePasswordButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button confirmPasswordButton;
        private System.Windows.Forms.Button generatePassword;
    }
}