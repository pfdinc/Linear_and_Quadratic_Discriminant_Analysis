using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


////{1BF} this is so you can move the borderless form 
using System.Runtime.InteropServices;

namespace L_Q
{
    public partial class Form1 : Form
    {
        // testpage linerPage; 
        ////{2BF} this is so you can move the borderless form 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //***********************************************************************
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
            if (panel2.Width == 206)
            {

                button5.Text = "MAX";
                panel2.Width = 50;

                /// button width change to 45px
                button1.Width = 45;
                button2.Width = 45;
                button3.Width = 45;
                button4.Width = 45;

                //this will fix the main panel





            } else if (panel2.Width == 50) {
                button5.Text = "MIN";
                panel2.Width = 206;

                //button width change to 200 px 
                button1.Width = 200;
                button2.Width = 200;
                button3.Width = 200;
                button4.Width = 200;

            }
        }

        /// <summary>
        /// This will exit the Form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// This will Minamize the entire form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// this will show  the content of the usercontrolview  for the Liner 
        /// </summary>
        /// <param name="content"></param>
        private void showContentLinear(Control content) {

            panel4.Controls.Clear(); // clear current content
            panel4.Controls.Add(content); // add new
            content.Dock = DockStyle.Fill; // fill placeholder area

        }

      

        /// <summary>
        /// this is the Linear Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            showContentLinear(new testpage());
        }


        /// <summary>
        /// this is the button for the quadratic 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            showContentLinear(new testpage2()); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showContentLinear(new settingPage());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showContentLinear(new aboutPage());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// ////{1BF} this is so you can move the borderless form 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

        }
    }
}
