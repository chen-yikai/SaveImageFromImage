using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveImageFromImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadImage_click(object sender, EventArgs e)
        {
            string imagePath = @"C:\Users\elias\Desktop\custom\eliaschen.jpg";

            Image image = Image.FromFile(imagePath);
            pictureBox1.Image = image;
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            string imagePath = @"C:\Users\elias\Desktop\custom\eliaschen.jpg";
            string saveTarget = @"C:\Users\elias\Desktop\custom";


            Image image = Image.FromFile(imagePath);
            image.Save(System.IO.Path.Combine(saveTarget, NewFileName.Text + ".png"), System.Drawing.Imaging.ImageFormat.Png);
            image.Dispose();
        }
    }
}
