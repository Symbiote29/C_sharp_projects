namespace CinemaApplication
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.mostPopularGenreChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statisticLabel = new System.Windows.Forms.Label();
            this.popularGenreBtn = new System.Windows.Forms.Button();
            this.popularMovieBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.mostPopularMoviesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.mostPopularGenreChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostPopularMoviesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistic shown for";
            // 
            // mostPopularGenreChart
            // 
            chartArea1.Name = "ChartArea1";
            this.mostPopularGenreChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mostPopularGenreChart.Legends.Add(legend1);
            this.mostPopularGenreChart.Location = new System.Drawing.Point(23, 78);
            this.mostPopularGenreChart.Margin = new System.Windows.Forms.Padding(4);
            this.mostPopularGenreChart.Name = "mostPopularGenreChart";
            this.mostPopularGenreChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Genre";
            this.mostPopularGenreChart.Series.Add(series1);
            this.mostPopularGenreChart.Size = new System.Drawing.Size(1605, 592);
            this.mostPopularGenreChart.TabIndex = 0;
            this.mostPopularGenreChart.Text = "Most popular genre";
            title1.Name = "Most viewed genre";
            this.mostPopularGenreChart.Titles.Add(title1);
            // 
            // statisticLabel
            // 
            this.statisticLabel.AutoSize = true;
            this.statisticLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticLabel.ForeColor = System.Drawing.Color.White;
            this.statisticLabel.Location = new System.Drawing.Point(337, 22);
            this.statisticLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statisticLabel.Name = "statisticLabel";
            this.statisticLabel.Size = new System.Drawing.Size(0, 36);
            this.statisticLabel.TabIndex = 2;
            // 
            // popularGenreBtn
            // 
            this.popularGenreBtn.Location = new System.Drawing.Point(1203, 698);
            this.popularGenreBtn.Margin = new System.Windows.Forms.Padding(4);
            this.popularGenreBtn.Name = "popularGenreBtn";
            this.popularGenreBtn.Size = new System.Drawing.Size(181, 58);
            this.popularGenreBtn.TabIndex = 3;
            this.popularGenreBtn.Text = "Genre popularity";
            this.popularGenreBtn.UseVisualStyleBackColor = true;
            this.popularGenreBtn.Click += new System.EventHandler(this.popularGenreBtn_Click);
            // 
            // popularMovieBtn
            // 
            this.popularMovieBtn.Location = new System.Drawing.Point(1447, 698);
            this.popularMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.popularMovieBtn.Name = "popularMovieBtn";
            this.popularMovieBtn.Size = new System.Drawing.Size(181, 58);
            this.popularMovieBtn.TabIndex = 4;
            this.popularMovieBtn.Text = "Movie popularity";
            this.popularMovieBtn.UseVisualStyleBackColor = true;
            this.popularMovieBtn.Click += new System.EventHandler(this.popularMovieBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(960, 698);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(181, 58);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // mostPopularMoviesChart
            // 
            this.mostPopularMoviesChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chartArea2.Name = "ChartArea1";
            this.mostPopularMoviesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.mostPopularMoviesChart.Legends.Add(legend2);
            this.mostPopularMoviesChart.Location = new System.Drawing.Point(23, 78);
            this.mostPopularMoviesChart.Margin = new System.Windows.Forms.Padding(4);
            this.mostPopularMoviesChart.Name = "mostPopularMoviesChart";
            this.mostPopularMoviesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "MovieName";
            this.mostPopularMoviesChart.Series.Add(series2);
            this.mostPopularMoviesChart.Size = new System.Drawing.Size(1605, 592);
            this.mostPopularMoviesChart.TabIndex = 6;
            this.mostPopularMoviesChart.Text = "Most popular movies";
            title2.Name = "Most viewed genre";
            this.mostPopularMoviesChart.Titles.Add(title2);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1668, 784);
            this.Controls.Add(this.mostPopularMoviesChart);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.popularMovieBtn);
            this.Controls.Add(this.popularGenreBtn);
            this.Controls.Add(this.statisticLabel);
            this.Controls.Add(this.mostPopularGenreChart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostPopularGenreChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostPopularMoviesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart mostPopularGenreChart;
        private System.Windows.Forms.Label statisticLabel;
        private System.Windows.Forms.Button popularGenreBtn;
        private System.Windows.Forms.Button popularMovieBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart mostPopularMoviesChart;
    }
}