namespace CinemaApplication
{
    partial class ReviewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.reviewDataGrid = new System.Windows.Forms.DataGridView();
            this.addReviewBtn = new System.Windows.Forms.Button();
            this.editReviewBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.deleteReviewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reviews for";
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameLabel.ForeColor = System.Drawing.Color.White;
            this.movieNameLabel.Location = new System.Drawing.Point(149, 9);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(0, 25);
            this.movieNameLabel.TabIndex = 2;
            // 
            // reviewDataGrid
            // 
            this.reviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewDataGrid.Location = new System.Drawing.Point(17, 51);
            this.reviewDataGrid.Name = "reviewDataGrid";
            this.reviewDataGrid.RowTemplate.Height = 50;
            this.reviewDataGrid.Size = new System.Drawing.Size(752, 460);
            this.reviewDataGrid.TabIndex = 3;
            // 
            // addReviewBtn
            // 
            this.addReviewBtn.Location = new System.Drawing.Point(660, 542);
            this.addReviewBtn.Name = "addReviewBtn";
            this.addReviewBtn.Size = new System.Drawing.Size(109, 46);
            this.addReviewBtn.TabIndex = 4;
            this.addReviewBtn.Text = "Add review";
            this.addReviewBtn.UseVisualStyleBackColor = true;
            this.addReviewBtn.Click += new System.EventHandler(this.addReviewBtn_Click);
            // 
            // editReviewBtn
            // 
            this.editReviewBtn.Location = new System.Drawing.Point(516, 542);
            this.editReviewBtn.Name = "editReviewBtn";
            this.editReviewBtn.Size = new System.Drawing.Size(113, 46);
            this.editReviewBtn.TabIndex = 5;
            this.editReviewBtn.Text = "Edit review";
            this.editReviewBtn.UseVisualStyleBackColor = true;
            this.editReviewBtn.Click += new System.EventHandler(this.editReviewBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(233, 542);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(113, 46);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // deleteReviewBtn
            // 
            this.deleteReviewBtn.Location = new System.Drawing.Point(377, 542);
            this.deleteReviewBtn.Name = "deleteReviewBtn";
            this.deleteReviewBtn.Size = new System.Drawing.Size(113, 46);
            this.deleteReviewBtn.TabIndex = 7;
            this.deleteReviewBtn.Text = "Delete Review";
            this.deleteReviewBtn.UseVisualStyleBackColor = true;
            this.deleteReviewBtn.Click += new System.EventHandler(this.deleteReviewBtn_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(789, 623);
            this.Controls.Add(this.deleteReviewBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.editReviewBtn);
            this.Controls.Add(this.addReviewBtn);
            this.Controls.Add(this.reviewDataGrid);
            this.Controls.Add(this.movieNameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reviewDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.DataGridView reviewDataGrid;
        private System.Windows.Forms.Button addReviewBtn;
        private System.Windows.Forms.Button editReviewBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button deleteReviewBtn;
    }
}