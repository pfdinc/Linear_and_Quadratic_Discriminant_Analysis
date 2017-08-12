namespace L_Q
{
    partial class linearGraph
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
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartLinear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartLinear)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLinear
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLogarithmic = true;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.LogarithmBase = 100D;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            stripLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            stripLine1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            stripLine1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkHorizontal;
            stripLine1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            stripLine1.BackSecondaryColor = System.Drawing.Color.Yellow;
            stripLine1.BorderColor = System.Drawing.Color.Green;
            stripLine1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            stripLine1.ForeColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX2.Crossing = 1.7976931348623157E+308D;
            chartArea1.AxisX2.IsLogarithmic = true;
            chartArea1.AxisX2.LogarithmBase = 100D;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IsLogarithmic = true;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisY.LogarithmBase = 100D;
            chartArea1.AxisY2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY2.LogarithmBase = 100D;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 96.41687F;
            chartArea1.InnerPlotPosition.Width = 96.3968F;
            chartArea1.InnerPlotPosition.X = 1.060318F;
            chartArea1.InnerPlotPosition.Y = 0.22937F;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 91.07381F;
            chartArea1.Position.Width = 96F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 7.926185F;
            chartArea1.ShadowColor = System.Drawing.Color.Gray;
            this.chartLinear.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartLinear.Legends.Add(legend1);
            this.chartLinear.Location = new System.Drawing.Point(0, 0);
            this.chartLinear.Name = "chartLinear";
            this.chartLinear.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Legend = "Legend1";
            series1.Name = "Class1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Legend = "Legend1";
            series2.Name = "Class2";
            this.chartLinear.Series.Add(series1);
            this.chartLinear.Series.Add(series2);
            this.chartLinear.Size = new System.Drawing.Size(946, 697);
            this.chartLinear.TabIndex = 0;
            this.chartLinear.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Linear Chart";
            this.chartLinear.Titles.Add(title1);
            this.chartLinear.Click += new System.EventHandler(this.chart1_Click);
            // 
            // linearGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartLinear);
            this.Name = "linearGraph";
            this.Size = new System.Drawing.Size(949, 697);
            this.Load += new System.EventHandler(this.linearGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartLinear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartLinear;
    }
}
