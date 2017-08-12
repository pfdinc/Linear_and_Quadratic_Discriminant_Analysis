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


/// <summary>
//TODO: create a line with matching coordnants to the graph 
/// </summary>
namespace L_Q
{
    public partial class testpage : UserControl
    {
        /// <summary>
        /// <stp1> 
        /// this is for the line on panel 
        /// </stp1>
        /// </summary>
        private IList<Point> _pointList = new List<Point>();


        public testpage()
        {
            InitializeComponent();
        }

        private void testpage_Load(object sender, EventArgs e)
        {
            
            
        }

        /// <summary>
        /// <stp2>
        /// this is the second step to draw the line 
        /// </stp2>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linearChartPanel_MouseMove(object sender, MouseEventArgs e) {

            _pointList.Add( e.Location );
            linearChartPanel.Invalidate();

        }

        private void linearChartPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLines(Pens.Black, _pointList);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this will fill up the choosen panel
        /// </summary>
        /// <param name="content"></param>
        
        private void showContentLinear(Control content)
        {

            linearChartPanel.Controls.Clear(); // clear current content
            linearChartPanel.Controls.Add(content); // add new
            content.Dock = DockStyle.Fill; // fill placeholder area

        }

        private void linearChartPanel_Paint(object sender, PaintEventArgs e)
        {
            showContentLinear(new linearGraph());
        }
    }
}
