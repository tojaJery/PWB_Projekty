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
            // Wyświetlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki PNG (*.png)|*.png|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik PNG do wczytania";
            openFileDialog1.ShowDialog();
            // Jeśli użytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywołanie funkcji wczytującej dane z pliku CSV
                LoadImage(openFileDialog1.FileName);

            }
        }
        private void LoadImage(string path)
        {
            // Wczytanie obrazu z pliku
            Bitmap image = new Bitmap(path);
            // Wyświetlenie obrazu w kontrolce PictureBox
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
                        if (image.GetPixel(i, j).R >= 120 || image.GetPixel(i, j).G <= 70 || image.GetPixel(i, j).B >=120)
                        {
                            image.SetPixel(i, j, Color.Black);
                        }

                    }
                }
                pictureBox1.Image = image;

            }
        }
    }
}
