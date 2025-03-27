namespace ObrazMod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Wyœwietlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki PNG (*.png)|*.png|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik PNG do wczytania";
            openFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywo³anie funkcji wczytuj¹cej dane z pliku CSV
                LoadImage(openFileDialog1.FileName);

            }
        }
        private void LoadImage(string path)
        {
            // Wczytanie obrazu z pliku
            Bitmap image = new Bitmap(path);
            // Wyœwietlenie obrazu w kontrolce PictureBox
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonOnlyGreen_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        //if color pixel not green -> change to black
                        if (image.GetPixel(i, j).R >= 120 || image.GetPixel(i, j).G <= 70 || image.GetPixel(i, j).B >= 120)
                        {
                            image.SetPixel(i, j, Color.Black);
                        }

                    }
                }
                pictureBox1.Image = image;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //invert colors
            if (pictureBox1 != null)
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        Color pixel = image.GetPixel(i, j);
                        image.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                    }
                }
                pictureBox1.Image = image;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //rotate image by (radiobutton) degrees
            if (pictureBox1 != null)
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                if (radioButton1.Checked)
                {
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (radioButton2.Checked)
                {
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (radioButton3.Checked)
                {
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                pictureBox1.Image = image;
            }
        }
    }
}
