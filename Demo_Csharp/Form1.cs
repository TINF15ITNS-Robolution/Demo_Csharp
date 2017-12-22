using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Csharp
{
    public partial class Form1 : Form
    {
        Population population;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            panelPitch.Paint += new PaintEventHandler(panelPitch_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            population = new Population();
        }
        private void panelPitch_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;
            foreach (IRocketDrawable rocket in population.rockets)
            {
                g.DrawImage(RotateImage(rocket.Image, rocket.Angle), rocket.Position);
            }

        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            timerRender.Enabled = !timerRender.Enabled;
            labelEnabled.Text = "rendering: " + timerRender.Enabled;
        }

        private void timerRender_Tick(object sender, EventArgs e)
        {
            population.CalculateYear();
            panelPitch.Invalidate();
        }

        public static Bitmap RotateImage(Image b, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
            }
            return returnBitmap;
        }
    }
}
