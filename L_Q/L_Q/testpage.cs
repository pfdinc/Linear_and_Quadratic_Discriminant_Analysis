using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace L_Q
{
    public partial class testpage : UserControl
    {
        public testpage()
        {
            InitializeComponent();
        }

        private void testpage_Load(object sender, EventArgs e)
        {
            /*Data arrays.
            string[] seriesArray = { "Class1", "Class2" };
            int[] pointsArray = { 1, 2 ,3};

            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add("Linear Discrimenant Analysis");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
               Series series = this.chart1.Series.Add(seriesArray[i]);

                // Add point.
               series.Points.Add(pointsArray[i]);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
