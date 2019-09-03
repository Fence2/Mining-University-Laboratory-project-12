using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex12._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Point PreviousPoint, point, dot, center;
        private Bitmap bmp;
        private Pen Pen;
        private SolidBrush dotPen;
        private Random rnd = new Random();
        private Graphics g;
        private int color;
        private double maxGradient;

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen = new Pen(Color.Black, 4);
            colorPanel.BringToFront();
            gradientPanel.BringToFront();
            oneColorPanel.BringToFront();
            center.X = pictureBox1.Width / 2;
            center.Y = pictureBox1.Height / 2;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, " + "*.GIF, *.PNG)|*.bmp;*.jpg;*.gif;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName); int width = image.Width; int height = image.Height;

                width = pictureBox1.Width;
                height = pictureBox1.Height;
                bmp = new Bitmap(image, width, height);

                pictureBox1.Image = bmp;
                g = Graphics.FromImage(pictureBox1.Image);

            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "Bitmap File(*.bmp)|*.bmp|" + "GIF File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.jpg|" + "PNG File(*.png)|*.png";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PreviousPoint.X = e.X;

            PreviousPoint.Y = e.Y;

        }

        private void gradientButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    int R = bmp.GetPixel(i, j).R;
                    int G = bmp.GetPixel(i, j).G;
                    int B = bmp.GetPixel(i, j).B;
                    int Gray = Convert.ToInt32(((R + G + B) / 3) * maxGradient);
                    Color p = Color.FromArgb(255, Gray, Gray, Gray);
                    bmp.SetPixel(i, j, p);
                }
            Refresh();
        }

        

        private void redButton_Click(object sender, EventArgs e)
        {
            Pen.Color = Color.Red;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            Pen.Color = Color.Yellow;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            Pen.Color = Color.Lime;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            Pen.Color = Color.Blue;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            Pen.Color = Color.White;
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            Pen.Color = Color.Black;
        }

        private void colorNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Pen.Width = Convert.ToInt32(colorNumericUpDown.Value);
        }

        private void gradientTrackBar_Scroll(object sender, EventArgs e)
        {
            maxGradient = gradientTrackBar.Value * 0.1;
        }

      

       

        

        

       

        private void oneColorPlayButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    int R = bmp.GetPixel(i, j).R;
                    int G = bmp.GetPixel(i, j).G;
                    int B = bmp.GetPixel(i, j).B;
                    if (radioButton_R.Checked)
                    {
                        Color p = Color.FromArgb(255, R, 0, 0);
                        bmp.SetPixel(i, j, p);
                    }
                    if (radioButton_G.Checked)
                    {
                        Color p = Color.FromArgb(255, 0, G, 0);
                        bmp.SetPixel(i, j, p);
                    }
                    if (radioButton_B.Checked)
                    {
                        Color p = Color.FromArgb(255, 0, 0, B);
                        bmp.SetPixel(i, j, p);
                    }
                }
            Refresh();
        }

        private void circleOfLifeBtn_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(Pens.Black, center.X - (Convert.ToSingle(circleNumericUpDown.Value) / 2), center.Y - (Convert.ToSingle(circleNumericUpDown.Value) / 2), Convert.ToSingle(circleNumericUpDown.Value), Convert.ToSingle(circleNumericUpDown.Value));
            pictureBox1.Invalidate();
        }

        private void dots1000_Click(object sender, EventArgs e)
        {
            dotPen = new SolidBrush(Color.Black);
            for (int i = 0; i < 1000; i++)
            {
                dot.X = rnd.Next(0, pictureBox1.Width);
                dot.Y = rnd.Next(0, pictureBox1.Height);
                color = rnd.Next(0, 7);
                switch (color)
                {
                    case 0:
                        dotPen.Color = Color.Red;
                        break;
                    case 1:
                        dotPen.Color = Color.Orange;
                        break;
                    case 2:
                        dotPen.Color = Color.Yellow;
                        break;
                    case 3:
                        dotPen.Color = Color.Green;
                        break;
                    case 4:
                        dotPen.Color = Color.LightBlue;
                        break;
                    case 5:
                        dotPen.Color = Color.Blue;
                        break;
                    case 6:
                        dotPen.Color = Color.Purple;
                        break;
                }
                g.FillRectangle(dotPen, dot.X, dot.Y, 2, 2);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point.X = e.X;
                point.Y = e.Y;
                g.DrawLine(Pen, PreviousPoint, point);

                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                pictureBox1.Invalidate();
            }
        }
    }
}
