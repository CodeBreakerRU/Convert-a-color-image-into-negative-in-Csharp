using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //read image

            Bitmap bmp = new Bitmap("C:\\Users\\Rasika\\Desktop\\IUP\\195641.jpg");

            //loac image in picture box 1

            pictureBox1.Image = Image.FromFile("C:\\Users\\Rasika\\Desktop\\IUP\\195641.jpg");

            // get image dimension

            int width = bmp.Width;
            int height = bmp.Height;

            // negative

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                { 
                    //get pixel value

                    Color p = bmp.GetPixel(x, y);

                    //extract ARGB values form p

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //fi6nd negative value

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    //set new ARGB value in pixel

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                }
            }

            //load negative image in picturebox2

            pictureBox2.Image = bmp;

            //save negative image

            bmp.Save("C:\\Users\\Rasika\\Desktop\\IUP\\negative.jpg");
        }
    }
}
