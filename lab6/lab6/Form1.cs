using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        Bitmap DrawArea;
        Graphics g;
        Stream fileStream = null;
        Image image;
        bool isMouseDown = false;
        int radius = 10;
        SolidBrush myBrush;



        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
     
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Image = DrawArea;
            myBrush = new SolidBrush(Color.Black);
            brushSizeText.Text = Convert.ToString(radius);
            g = Graphics.FromImage(DrawArea);
            g.Clear(Color.White);
            colorPanel.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            hexColor.Text = HexConverter(Color.Black);

        }

 

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            isMouseDown = true;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int centerX = e.X;
                int centerY = e.Y;

                g.FillEllipse(myBrush, centerX, centerY, radius, radius);

                pictureBox1.Image = DrawArea;
            }

        }

        private void loadPictureBtn_Click(object sender, EventArgs e)
        {
     
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Files|*.jpg;*.jpeg;";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (fileStream)
                        {
                       
                            image = new Bitmap(openFileDialog1.FileName);

                            if(image.Width < this.Width && image.Height< this.Height)
                            {
                                panel2.MinimumSize = new Size(image.Width, image.Height);
                                pictureBox1.MinimumSize = new Size(image.Width, image.Height);
                                this.MinimumSize = new Size(image.Width, image.Height);
                            } else
                            {
                                panel2.MinimumSize = new Size(800, 600);
                                pictureBox1.MinimumSize = new Size(800, 600);
                                this.MinimumSize = new Size(800, 600);
                            }
          


                            g.DrawImage(image, 0, 0, pictureBox1.Width, pictureBox1.Height);
                            pictureBox1.Image = DrawArea;
                            pictureNameBox.Text = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\')+1);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void brushSize_Click(object sender, EventArgs e)
        {
            int newRadius;

            if(Int32.TryParse(brushSizeText.Text,out newRadius))
            {
                radius = newRadius;
            }
            else
            {
                MessageBox.Show("Wrong size only integer allowed");
                brushSizeText.Text = Convert.ToString(radius);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                myBrush.Color = colorDialog1.Color;
                colorPanel.BackColor = colorDialog1.Color;
                hexColor.Text = HexConverter(colorDialog1.Color);

            }
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }




        private void panel2_Resize(object sender, EventArgs e)
        {

            makeScreenCopy();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {


            SaveFileDialog savefile = new SaveFileDialog();
            
            savefile.FileName = pictureNameBox.Text;
  
            savefile.Filter = "Files|*.jpg;*.jpeg;";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                image.Dispose();

                if (System.IO.File.Exists(savefile.FileName))
                    System.IO.File.Delete(savefile.FileName);

                DrawArea.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }


        private void Grayscale_Click(object sender, EventArgs e)
        {
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            DrawArea =  filter.Apply(DrawArea);
            pictureBox1.Image = DrawArea;

            makeScreenCopy();

        }



        private void Edges_Click(object sender, EventArgs e)
        {
            Edges filter = new Edges();

        }

 

        private void GaussianSharpen_Click(object sender, EventArgs e)
        {
            GaussianSharpen filter = new GaussianSharpen(4, 11);
            DrawArea = filter.Apply(DrawArea);
            pictureBox1.Image = DrawArea;

            makeScreenCopy();
        }

        private void makeScreenCopy()
        {
            pictureBox1.Width = panel2.Width;
            pictureBox1.Height = panel2.Height;


            Image screenCopy = pictureBox1.Image;
            DrawArea = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(DrawArea);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(screenCopy, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            pictureBox1.Image = DrawArea;
        }

 
    }
}

