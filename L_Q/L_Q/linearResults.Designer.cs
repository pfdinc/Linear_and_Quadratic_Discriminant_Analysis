namespace L_Q
{
    partial class linearResults
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

        #region Component Designer generated code

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
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // resultChart
            // 
            chartArea1.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.resultChart.Legends.Add(legend1);
            this.resultChart.Location = new System.Drawing.Point(0, 3);
            this.resultChart.Name = "resultChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.resultChart.Series.Add(series1);
            this.resultChart.Size = new System.Drawing.Size(300, 255);
            this.resultChart.TabIndex = 0;
            this.resultChart.Text = "chart1";
            title1.Name = "Title1";
            this.resultChart.Titles.Add(title1);
            // 
            // linearResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultChart);
            this.Name = "linearResults";
            this.Size = new System.Drawing.Size(307, 323);
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
    }
}
