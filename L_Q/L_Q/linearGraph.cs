using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_Q
{
    public partial class linearGraph : UserControl
    {
        public linearGraph()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void linearGraph_Load(object sender, EventArgs e)
        {
            //chartLinear.Series["Series1"].Points.AddXY(3 , 33);

            

            Random rnd = new Random();
            Random rnd2 = new Random();
            for (int x = 1; x <= 100; x++)
            {
                int flip = rnd.Next(1, 100);
                int flip2 = rnd2.Next(1, 100);
                int flip4 = rnd.Next(1, 100);
                int flip5 = rnd2.Next(1, 100);
                //do stuff
                chartLinear.Series["Class2"].Points.AddXY(flip, flip2);
                chartLinear.Series["Class1"].Points.AddXY(flip4, flip5);
            }


            


        }
    }
}
