namespace FootyC_
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
            label1 = new Label();
            terminiDataGridView = new DataGridView();
            filterButton = new Button();
            terminDateFilter = new DateTimePicker();
            usernameText = new Label();
            logoutButton = new Button();
            resetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)terminiDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(793, 86);
            label1.TabIndex = 0;
            label1.Text = "Welcome to FOOTY TIME";
            // 
            // terminiDataGridView
            // 
            terminiDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            terminiDataGridView.Location = new Point(44, 287);
            terminiDataGridView.Name = "terminiDataGridView";
            terminiDataGridView.Size = new Size(793, 300);
            terminiDataGridView.TabIndex = 1;
            terminiDataGridView.CellClick += terminiDataGridView_CellClick;
            terminiDataGridView.RowPrePaint += terminiDataGridView_RowPrePaint;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(264, 230);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(82, 34);
            filterButton.TabIndex = 2;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // terminDateFilter
            // 
            terminDateFilter.Location = new Point(44, 234);
            terminDateFilter.Name = "terminDateFilter";
            terminDateFilter.Size = new Size(200, 23);
            terminDateFilter.TabIndex = 3;
            // 
            // usernameText
            // 
            usernameText.AutoSize = true;
            usernameText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            usernameText.Location = new Point(1082, 26);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(50, 20);
            usernameText.TabIndex = 4;
            usernameText.Text = "label2";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(1049, 644);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(99, 48);
            logoutButton.TabIndex = 5;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(362, 230);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(82, 34);
            resetButton.TabIndex = 6;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 714);
            Controls.Add(resetButton);
            Controls.Add(logoutButton);
            Controls.Add(usernameText);
            Controls.Add(terminDateFilter);
            Controls.Add(filterButton);
            Controls.Add(terminiDataGridView);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)terminiDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView terminiDataGridView;
        private Button filterButton;
        private DateTimePicker terminDateFilter;
        private Label usernameText;
        private Button logoutButton;
        private Button resetButton;
    }
}