namespace FootyC_
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            prijaviseButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            backButton = new Button();
            label14 = new Label();
            playerListDataGridView = new DataGridView();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1026, 685);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(1248, 38);
            label1.Name = "label1";
            label1.Size = new Size(547, 50);
            label1.TabIndex = 1;
            label1.Text = "Arena centar nogometni teren";
            // 
            // prijaviseButton
            // 
            prijaviseButton.Location = new Point(1272, 569);
            prijaviseButton.Name = "prijaviseButton";
            prijaviseButton.Size = new Size(93, 41);
            prijaviseButton.TabIndex = 2;
            prijaviseButton.Text = "Prijavi se";
            prijaviseButton.UseVisualStyleBackColor = true;
            prijaviseButton.Click += prijaviseButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1120, 194);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Naziv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1120, 230);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Datum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1116, 270);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Vrijeme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1120, 313);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 6;
            label5.Text = "Mjesto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1116, 362);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 7;
            label6.Text = "Broj igrača";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1080, 405);
            label7.Name = "label7";
            label7.Size = new Size(140, 15);
            label7.TabIndex = 8;
            label7.Text = "Prosječna ocjena termina";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1301, 192);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 9;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1301, 230);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 10;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1295, 270);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 11;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1295, 313);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 12;
            label11.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1295, 362);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 13;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1295, 405);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 14;
            label13.Text = "label13";
            // 
            // backButton
            // 
            backButton.Location = new Point(1086, 569);
            backButton.Name = "backButton";
            backButton.Size = new Size(93, 41);
            backButton.TabIndex = 15;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label14.Location = new Point(1448, 154);
            label14.Name = "label14";
            label14.Size = new Size(131, 30);
            label14.TabIndex = 16;
            label14.Text = "Popis igrača";
            // 
            // playerListDataGridView
            // 
            playerListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerListDataGridView.Location = new Point(1448, 210);
            playerListDataGridView.Name = "playerListDataGridView";
            playerListDataGridView.Size = new Size(513, 210);
            playerListDataGridView.TabIndex = 17;
            playerListDataGridView.CellClick += playerListDataGridView_CellClick;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(1868, 443);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(93, 41);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel reservation";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2002, 684);
            Controls.Add(cancelButton);
            Controls.Add(playerListDataGridView);
            Controls.Add(label14);
            Controls.Add(backButton);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(prijaviseButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerListDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button prijaviseButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button backButton;
        private Label label14;
        private DataGridView playerListDataGridView;
        private Button cancelButton;
    }
}