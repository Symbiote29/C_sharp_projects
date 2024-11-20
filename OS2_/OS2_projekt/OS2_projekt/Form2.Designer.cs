namespace OS2_projekt
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.asymetricAlgorithms = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.afterTextBox = new System.Windows.Forms.TextBox();
            this.beforeTextBox = new System.Windows.Forms.TextBox();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptedTextBox = new System.Windows.Forms.TextBox();
            this.uploadDecryptButton2 = new System.Windows.Forms.Button();
            this.calculateHashButton2 = new System.Windows.Forms.Button();
            this.hashTextBox2 = new System.Windows.Forms.TextBox();
            this.checkTextBox = new System.Windows.Forms.TextBox();
            this.signatureTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.uploadButton3 = new System.Windows.Forms.Button();
            this.signedTextBox = new System.Windows.Forms.TextBox();
            this.signButton = new System.Windows.Forms.Button();
            this.digitalTextBox = new System.Windows.Forms.TextBox();
            this.uploadButton2 = new System.Windows.Forms.Button();
            this.generateKeysButton = new System.Windows.Forms.Button();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.choosePublicKeyButton = new System.Windows.Forms.Button();
            this.chosenPublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.privateKeyButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputStringTextBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 22);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(121, 20);
            this.pathTextBox.TabIndex = 14;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(152, 12);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(107, 38);
            this.uploadButton.TabIndex = 13;
            this.uploadButton.Text = "Upload .txt file";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // asymetricAlgorithms
            // 
            this.asymetricAlgorithms.FormattingEnabled = true;
            this.asymetricAlgorithms.Items.AddRange(new object[] {
            "RSA",
            "Diffie-Hellman",
            "ECC",
            "El Gamal",
            "DSA"});
            this.asymetricAlgorithms.Location = new System.Drawing.Point(315, 305);
            this.asymetricAlgorithms.Name = "asymetricAlgorithms";
            this.asymetricAlgorithms.Size = new System.Drawing.Size(121, 21);
            this.asymetricAlgorithms.TabIndex = 11;
            this.asymetricAlgorithms.Text = "RSA";
            this.asymetricAlgorithms.SelectionChangeCommitted += new System.EventHandler(this.asymetricAlgorithms_SelectionChangeCommitted);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1295, 656);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 49);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // afterTextBox
            // 
            this.afterTextBox.Location = new System.Drawing.Point(407, 383);
            this.afterTextBox.Multiline = true;
            this.afterTextBox.Name = "afterTextBox";
            this.afterTextBox.Size = new System.Drawing.Size(297, 54);
            this.afterTextBox.TabIndex = 32;
            // 
            // beforeTextBox
            // 
            this.beforeTextBox.Location = new System.Drawing.Point(70, 457);
            this.beforeTextBox.Multiline = true;
            this.beforeTextBox.Name = "beforeTextBox";
            this.beforeTextBox.Size = new System.Drawing.Size(297, 81);
            this.beforeTextBox.TabIndex = 31;
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(70, 383);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(297, 54);
            this.plainTextBox.TabIndex = 30;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(517, 329);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 37);
            this.decryptButton.TabIndex = 29;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click_1);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(172, 329);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 38);
            this.encryptButton.TabIndex = 28;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click_1);
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(407, 457);
            this.decryptedTextBox.Multiline = true;
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.Size = new System.Drawing.Size(297, 81);
            this.decryptedTextBox.TabIndex = 33;
            // 
            // uploadDecryptButton2
            // 
            this.uploadDecryptButton2.Location = new System.Drawing.Point(492, 12);
            this.uploadDecryptButton2.Name = "uploadDecryptButton2";
            this.uploadDecryptButton2.Size = new System.Drawing.Size(107, 38);
            this.uploadDecryptButton2.TabIndex = 34;
            this.uploadDecryptButton2.Text = "Upload file to decrypt";
            this.uploadDecryptButton2.UseVisualStyleBackColor = true;
            this.uploadDecryptButton2.Click += new System.EventHandler(this.uploadDecryptButton2_Click);
            // 
            // calculateHashButton2
            // 
            this.calculateHashButton2.Location = new System.Drawing.Point(172, 558);
            this.calculateHashButton2.Name = "calculateHashButton2";
            this.calculateHashButton2.Size = new System.Drawing.Size(75, 38);
            this.calculateHashButton2.TabIndex = 35;
            this.calculateHashButton2.Text = "Calculate hash";
            this.calculateHashButton2.UseVisualStyleBackColor = true;
            this.calculateHashButton2.Click += new System.EventHandler(this.calculateHashButton2_Click);
            // 
            // hashTextBox2
            // 
            this.hashTextBox2.Location = new System.Drawing.Point(70, 624);
            this.hashTextBox2.Multiline = true;
            this.hashTextBox2.Name = "hashTextBox2";
            this.hashTextBox2.Size = new System.Drawing.Size(297, 81);
            this.hashTextBox2.TabIndex = 36;
            // 
            // checkTextBox
            // 
            this.checkTextBox.Location = new System.Drawing.Point(764, 178);
            this.checkTextBox.Multiline = true;
            this.checkTextBox.Name = "checkTextBox";
            this.checkTextBox.Size = new System.Drawing.Size(297, 81);
            this.checkTextBox.TabIndex = 45;
            // 
            // signatureTextBox
            // 
            this.signatureTextBox.Location = new System.Drawing.Point(1079, 457);
            this.signatureTextBox.Multiline = true;
            this.signatureTextBox.Name = "signatureTextBox";
            this.signatureTextBox.Size = new System.Drawing.Size(297, 81);
            this.signatureTextBox.TabIndex = 44;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(966, 406);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 38);
            this.checkButton.TabIndex = 43;
            this.checkButton.Text = "Check signature";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // uploadButton3
            // 
            this.uploadButton3.Location = new System.Drawing.Point(856, 406);
            this.uploadButton3.Name = "uploadButton3";
            this.uploadButton3.Size = new System.Drawing.Size(93, 38);
            this.uploadButton3.TabIndex = 42;
            this.uploadButton3.Text = "Upload digital signature";
            this.uploadButton3.UseVisualStyleBackColor = true;
            this.uploadButton3.Click += new System.EventHandler(this.uploadButton3_Click);
            // 
            // signedTextBox
            // 
            this.signedTextBox.Location = new System.Drawing.Point(1091, 178);
            this.signedTextBox.Multiline = true;
            this.signedTextBox.Name = "signedTextBox";
            this.signedTextBox.Size = new System.Drawing.Size(297, 81);
            this.signedTextBox.TabIndex = 41;
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(874, 107);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(75, 38);
            this.signButton.TabIndex = 40;
            this.signButton.Text = "Sign message";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // digitalTextBox
            // 
            this.digitalTextBox.Location = new System.Drawing.Point(764, 457);
            this.digitalTextBox.Multiline = true;
            this.digitalTextBox.Name = "digitalTextBox";
            this.digitalTextBox.Size = new System.Drawing.Size(297, 81);
            this.digitalTextBox.TabIndex = 39;
            // 
            // uploadButton2
            // 
            this.uploadButton2.Location = new System.Drawing.Point(764, 107);
            this.uploadButton2.Name = "uploadButton2";
            this.uploadButton2.Size = new System.Drawing.Size(75, 38);
            this.uploadButton2.TabIndex = 38;
            this.uploadButton2.Text = "Upload .txt file";
            this.uploadButton2.UseVisualStyleBackColor = true;
            this.uploadButton2.Click += new System.EventHandler(this.uploadButton2_Click);
            // 
            // generateKeysButton
            // 
            this.generateKeysButton.Location = new System.Drawing.Point(348, 12);
            this.generateKeysButton.Name = "generateKeysButton";
            this.generateKeysButton.Size = new System.Drawing.Size(75, 38);
            this.generateKeysButton.TabIndex = 46;
            this.generateKeysButton.Text = "Generate keys";
            this.generateKeysButton.UseVisualStyleBackColor = true;
            this.generateKeysButton.Click += new System.EventHandler(this.generateKeysButton_Click);
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Location = new System.Drawing.Point(70, 127);
            this.publicKeyTextBox.Multiline = true;
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(297, 143);
            this.publicKeyTextBox.TabIndex = 47;
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.Location = new System.Drawing.Point(407, 127);
            this.privateKeyTextBox.Multiline = true;
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.Size = new System.Drawing.Size(297, 143);
            this.privateKeyTextBox.TabIndex = 48;
            // 
            // choosePublicKeyButton
            // 
            this.choosePublicKeyButton.Location = new System.Drawing.Point(764, 305);
            this.choosePublicKeyButton.Name = "choosePublicKeyButton";
            this.choosePublicKeyButton.Size = new System.Drawing.Size(75, 43);
            this.choosePublicKeyButton.TabIndex = 53;
            this.choosePublicKeyButton.Text = "Choose public key";
            this.choosePublicKeyButton.UseVisualStyleBackColor = true;
            this.choosePublicKeyButton.Click += new System.EventHandler(this.choosePublicKeyButton_Click);
            // 
            // chosenPublicKeyTextBox
            // 
            this.chosenPublicKeyTextBox.Location = new System.Drawing.Point(764, 369);
            this.chosenPublicKeyTextBox.Name = "chosenPublicKeyTextBox";
            this.chosenPublicKeyTextBox.Size = new System.Drawing.Size(286, 20);
            this.chosenPublicKeyTextBox.TabIndex = 52;
            // 
            // privateKeyButton
            // 
            this.privateKeyButton.Location = new System.Drawing.Point(764, 12);
            this.privateKeyButton.Name = "privateKeyButton";
            this.privateKeyButton.Size = new System.Drawing.Size(75, 37);
            this.privateKeyButton.TabIndex = 51;
            this.privateKeyButton.Text = "Choose private key";
            this.privateKeyButton.UseVisualStyleBackColor = true;
            this.privateKeyButton.Click += new System.EventHandler(this.privateKeyButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(764, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 50;
            // 
            // inputStringTextBox
            // 
            this.inputStringTextBox.Location = new System.Drawing.Point(764, 406);
            this.inputStringTextBox.Name = "inputStringTextBox";
            this.inputStringTextBox.Size = new System.Drawing.Size(75, 38);
            this.inputStringTextBox.TabIndex = 54;
            this.inputStringTextBox.Text = "Upload input string";
            this.inputStringTextBox.UseVisualStyleBackColor = true;
            this.inputStringTextBox.Click += new System.EventHandler(this.inputStringTextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(163, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Public key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(513, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Private key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1172, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Digital signature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(1120, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Checking digital signature";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 726);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputStringTextBox);
            this.Controls.Add(this.choosePublicKeyButton);
            this.Controls.Add(this.chosenPublicKeyTextBox);
            this.Controls.Add(this.privateKeyButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.privateKeyTextBox);
            this.Controls.Add(this.publicKeyTextBox);
            this.Controls.Add(this.generateKeysButton);
            this.Controls.Add(this.checkTextBox);
            this.Controls.Add(this.signatureTextBox);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.uploadButton3);
            this.Controls.Add(this.signedTextBox);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.digitalTextBox);
            this.Controls.Add(this.uploadButton2);
            this.Controls.Add(this.hashTextBox2);
            this.Controls.Add(this.calculateHashButton2);
            this.Controls.Add(this.uploadDecryptButton2);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.afterTextBox);
            this.Controls.Add(this.beforeTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.asymetricAlgorithms);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.ComboBox asymetricAlgorithms;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox afterTextBox;
        private System.Windows.Forms.TextBox beforeTextBox;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox decryptedTextBox;
        private System.Windows.Forms.Button uploadDecryptButton2;
        private System.Windows.Forms.Button calculateHashButton2;
        private System.Windows.Forms.TextBox hashTextBox2;
        private System.Windows.Forms.TextBox checkTextBox;
        private System.Windows.Forms.TextBox signatureTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button uploadButton3;
        private System.Windows.Forms.TextBox signedTextBox;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.TextBox digitalTextBox;
        private System.Windows.Forms.Button uploadButton2;
        private System.Windows.Forms.Button generateKeysButton;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.Button choosePublicKeyButton;
        private System.Windows.Forms.TextBox chosenPublicKeyTextBox;
        private System.Windows.Forms.Button privateKeyButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button inputStringTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}