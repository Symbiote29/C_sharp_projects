namespace FootyC_
{
    partial class Form6
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
            backButton = new Button();
            ratePlayerButton = new Button();
            scoreComboBox = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(69, 30);
            label1.Name = "label1";
            label1.Size = new Size(249, 50);
            label1.TabIndex = 2;
            label1.Text = "Rate a player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(151, 90);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // backButton
            // 
            backButton.Location = new Point(21, 374);
            backButton.Name = "backButton";
            backButton.Size = new Size(72, 31);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // ratePlayerButton
            // 
            ratePlayerButton.Location = new Point(123, 271);
            ratePlayerButton.Name = "ratePlayerButton";
            ratePlayerButton.Size = new Size(129, 43);
            ratePlayerButton.TabIndex = 5;
            ratePlayerButton.Text = "Rate Player";
            ratePlayerButton.UseVisualStyleBackColor = true;
            ratePlayerButton.Click += ratePlayerButton_Click;
            // 
            // scoreComboBox
            // 
            scoreComboBox.FormattingEnabled = true;
            scoreComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            scoreComboBox.Location = new Point(123, 215);
            scoreComboBox.Name = "scoreComboBox";
            scoreComboBox.Size = new Size(128, 23);
            scoreComboBox.TabIndex = 6;
            scoreComboBox.SelectedIndexChanged += scoreComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(122, 180);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 7;
            label3.Text = "Odaberite ocjenu";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 427);
            Controls.Add(label3);
            Controls.Add(scoreComboBox);
            Controls.Add(ratePlayerButton);
            Controls.Add(backButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button backButton;
        private Button ratePlayerButton;
        private ComboBox scoreComboBox;
        private Label label3;
    }
}