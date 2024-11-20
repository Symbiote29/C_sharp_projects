namespace CinemaApplication
{
    partial class SettingForms
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
            this.themeLbl = new System.Windows.Forms.Label();
            this.fontStyleCb = new System.Windows.Forms.ComboBox();
            this.fontStyleLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.themeCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // themeLbl
            // 
            this.themeLbl.AutoSize = true;
            this.themeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.themeLbl.Location = new System.Drawing.Point(103, 143);
            this.themeLbl.Name = "themeLbl";
            this.themeLbl.Size = new System.Drawing.Size(85, 25);
            this.themeLbl.TabIndex = 9;
            this.themeLbl.Text = "Theme :";
            // 
            // fontStyleCb
            // 
            this.fontStyleCb.FormattingEnabled = true;
            this.fontStyleCb.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Georgia",
            "Gadugi",
            "Lucida Console"});
            this.fontStyleCb.Location = new System.Drawing.Point(220, 93);
            this.fontStyleCb.Name = "fontStyleCb";
            this.fontStyleCb.Size = new System.Drawing.Size(176, 24);
            this.fontStyleCb.TabIndex = 8;
            this.fontStyleCb.Text = "Microsoft Sans Serif";
            this.fontStyleCb.SelectedIndexChanged += new System.EventHandler(this.fontStyleCb_SelectedIndexChanged);
            // 
            // fontStyleLbl
            // 
            this.fontStyleLbl.AutoSize = true;
            this.fontStyleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontStyleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.fontStyleLbl.Location = new System.Drawing.Point(103, 93);
            this.fontStyleLbl.Name = "fontStyleLbl";
            this.fontStyleLbl.Size = new System.Drawing.Size(111, 25);
            this.fontStyleLbl.TabIndex = 7;
            this.fontStyleLbl.Text = "Font Style :";
            // 
            // exitBtn
            // 
            this.exitBtn.AutoEllipsis = true;
            this.exitBtn.BackColor = System.Drawing.Color.DarkGray;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(165, 292);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(178, 90);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // themeCheckbox
            // 
            this.themeCheckbox.AutoSize = true;
            this.themeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeCheckbox.ForeColor = System.Drawing.SystemColors.Control;
            this.themeCheckbox.Location = new System.Drawing.Point(220, 142);
            this.themeCheckbox.Name = "themeCheckbox";
            this.themeCheckbox.Size = new System.Drawing.Size(135, 29);
            this.themeCheckbox.TabIndex = 5;
            this.themeCheckbox.Text = "Light theme";
            this.themeCheckbox.UseVisualStyleBackColor = true;
            this.themeCheckbox.CheckedChanged += new System.EventHandler(this.themeCheckbox_CheckedChanged);
            // 
            // SettingForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.themeLbl);
            this.Controls.Add(this.fontStyleCb);
            this.Controls.Add(this.fontStyleLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.themeCheckbox);
            this.Name = "SettingForms";
            this.Text = "Setting Forms";
            this.Load += new System.EventHandler(this.SettingForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label themeLbl;
        private System.Windows.Forms.ComboBox fontStyleCb;
        private System.Windows.Forms.Label fontStyleLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox themeCheckbox;
    }
}