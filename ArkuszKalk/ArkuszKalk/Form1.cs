using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;

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
                // Upewnij siê, ¿e nie próbujesz usun¹æ nag³ówka
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)  // Zapobiega usuniêciu nowego wiersza (jeœli istnieje)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Wyœwietlanie okna dialogowego wyboru lokalizacji zapisu
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizacjê zapisu pliku CSV";
            saveFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze lokalizacjê i zatwierdzi, zapisz plik CSV
            if (saveFileDialog1.FileName != "")
            {
                // U¿yj metody ExportToCSV i podaj obiekt DataGridView oraz œcie¿kê do pliku CSV
                ExportToCSV(dataGridView1, saveFileDialog1.FileName);
            }


        }
        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            // Tworzenie nag³ówka pliku CSV
            string csvContent = "Id,Imie,nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            // Dodawanie danych z DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Pomijaj wiersze niemieszcz¹ce siê w DataGridView (np. wiersz zaznaczania)
                if (!row.IsNewRow)
                {
                    // Dodaj kolejne wartoœci w wierszu, oddzielone przecinkami
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            // Zapisanie zawartoœci do pliku CSV
            File.WriteAllText(filePath, csvContent);
        }
        private void btnSaveToCSV_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Wyœwietlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywo³anie funkcji wczytuj¹cej dane z pliku CSV
                LoadCSVToDataGridView(openFileDialog1.FileName);
            }

        }
        private void LoadCSVToDataGridView(string filePath)
        {
            // SprawdŸ, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            // Odczytaj zawartoœæ pliku CSV
            string[] lines = File.ReadAllLines(filePath);
            // Tworzenie tabeli danych
            DataTable dataTable = new DataTable();
            // Dodanie kolumn na podstawie nag³ówka
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

        private void XMLButton_Click(object sender, EventArgs e)
        {
            List<Rekord> records = new List<Rekord>();
            string fileName = "rekord.xml";

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Rekord rek = new Rekord();
                rek.id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                rek.imie = dataGridView1.Rows[i].Cells[1].Value.ToString();
                rek.nazwisko = dataGridView1.Rows[i].Cells[2].Value.ToString();
                rek.wiek = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                rek.stanowisko = dataGridView1.Rows[i].Cells[4].Value.ToString();

                records.Add(rek);
            }
            XmlSerializer listSerializer = new XmlSerializer(typeof(List<Rekord>));
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            using (TextWriter writer = new StreamWriter(fileStream))
            {
                listSerializer.Serialize(writer, records);
            }

            MessageBox.Show("Zapisano rekordy do plików XML.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeserializeXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik XML do wczytania";
            openFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku XML
            if (openFileDialog1.FileName != "")
            {
                //deserializacja z XML
                XmlSerializer listSerializer = new XmlSerializer(typeof(List<Rekord>));
                using (FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    List<Rekord> records = (List<Rekord>)listSerializer.Deserialize(fileStream);
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    // Tworzenie tabeli danych
                    DataTable dataTable = new DataTable();
                    // Dodanie kolumn na podstawie nag³ówka
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Imie");
                    dataTable.Columns.Add("Nazwisko");
                    dataTable.Columns.Add("Wiek");
                    dataTable.Columns.Add("Stanowisko");
                    foreach (var rek in records)
                    {
                        dataTable.Rows.Add(rek.id, rek.imie, rek.nazwisko, rek.wiek, rek.stanowisko);
                    }
                    // Przypisanie tabeli danych do DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                MessageBox.Show("Wczytano rekordy z pliku XML.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
