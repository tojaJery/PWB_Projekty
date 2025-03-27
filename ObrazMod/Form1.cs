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
    }
}
