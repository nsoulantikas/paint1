using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool mouse_down = false;
        private Bitmap bit = new Bitmap("./sample.png");
        private Color col = Color.Black;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_down = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = e.X + "," + e.Y;
            if (mouse_down == true)
            {
                bit = new Bitmap(bit, panel1.Size);
                panel1.BackgroundImage = bit;
                bit.SetPixel(e.X, e.Y, col);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            col = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
