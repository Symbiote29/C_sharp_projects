namespace OS2_projekt
{
    partial class Form1
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
            this.assymetricButton = new System.Windows.Forms.Button();
            this.symmetricButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assymetricButton
            // 
            this.assymetricButton.Location = new System.Drawing.Point(281, 153);
            this.assymetricButton.Name = "assymetricButton";
            this.assymetricButton.Size = new System.Drawing.Size(94, 77);
            this.assymetricButton.TabIndex = 9;
            this.assymetricButton.Text = "Assymetric algorithms";
            this.assymetricButton.UseVisualStyleBackColor = true;
            this.assymetricButton.Click += new System.EventHandler(this.assymetricButton_Click);
            // 
            // symmetricButton
            // 
            this.symmetricButton.Location = new System.Drawing.Point(381, 153);
            this.symmetricButton.Name = "symmetricButton";
            this.symmetricButton.Size = new System.Drawing.Size(94, 77);
            this.symmetricButton.TabIndex = 10;
            this.symmetricButton.Text = "Symmetric algorithms";
            this.symmetricButton.UseVisualStyleBackColor = true;
            this.symmetricButton.Click += new System.EventHandler(this.symmetricButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.symmetricButton);
            this.Controls.Add(this.assymetricButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button assymetricButton;
        private System.Windows.Forms.Button symmetricButton;
    }
}

