using System.Data;
using System.Windows.Forms;

namespace ArkuszKalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (form2.NowyRekord != null)
            {
                // Dodajemy dane do DataGridView
                dataGridView1.Rows.Add(form2.NowyRekord.id, form2.NowyRekord.imie, form2.NowyRekord.nazwisko, form2.NowyRekord.wiek, form2.NowyRekord.stanowisko);
            }





        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Upewnij si�, �e nie pr�bujesz usun�� nag��wka
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)  // Zapobiega usuni�ciu nowego wiersza (je�li istnieje)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Wy�wietlanie okna dialogowego wyboru lokalizacji zapisu
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizacj� zapisu pliku CSV";
            saveFileDialog1.ShowDialog();
            // Je�li u�ytkownik wybierze lokalizacj� i zatwierdzi, zapisz plik CSV
            if (saveFileDialog1.FileName != "")
            {
                // U�yj metody ExportToCSV i podaj obiekt DataGridView oraz �cie�k� do pliku CSV
                ExportToCSV(dataGridView1, saveFileDialog1.FileName);
            }


        }
        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            // Tworzenie nag��wka pliku CSV
            string csvContent = "Id,Imie,nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            // Dodawanie danych z DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Pomijaj wiersze niemieszcz�ce si� w DataGridView (np. wiersz zaznaczania)
                if (!row.IsNewRow)
                {
                    // Dodaj kolejne warto�ci w wierszu, oddzielone przecinkami
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            // Zapisanie zawarto�ci do pliku CSV
            File.WriteAllText(filePath, csvContent);
        }
        private void btnSaveToCSV_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Wy�wietlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Je�li u�ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywo�anie funkcji wczytuj�cej dane z pliku CSV
                LoadCSVToDataGridView(openFileDialog1.FileName);
            }

        }
        private void LoadCSVToDataGridView(string filePath)
        {
            // Sprawd�, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            // Odczytaj zawarto�� pliku CSV
            string[] lines = File.ReadAllLines(filePath);
            // Tworzenie tabeli danych
            DataTable dataTable = new DataTable();
            // Dodanie kolumn na podstawie nag��wka
            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }
            // Dodawanie wierszy do tabeli danych
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                dataTable.Rows.Add(values);
            }
            // Przypisanie tabeli danych do DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }
}
