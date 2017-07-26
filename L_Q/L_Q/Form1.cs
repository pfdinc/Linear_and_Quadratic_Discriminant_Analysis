using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_Q
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Width = 200;
            button2.Width = 200;
            button3.Width = 200;
            button4.Width = 200;
        }


        /// <summary>
        /// this button will minamize and maximixe buttons and panel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 240) {

                button5.Text = "MAX";
                panel2.Width = 50;

                /// button width change 
                button1.Width = 45;
                button2.Width = 45;
                button3.Width = 45;
                button4.Width = 45;


            } else if (panel2.Width == 50) {
                button5.Text = "MIN";
                panel2.Width = 240;

                //button width change to 200 px 
                button1.Width = 200;
                button2.Width = 200;
                button3.Width = 200;
                button4.Width = 200;









            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
