using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6Dydelf
{
    public partial class UstawieniaForm : Form
    {
        public UstawieniaForm()
        {
            InitializeComponent();
        }

        private void buttonZAPISZUSTAWIENIA_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(comboBoxX.Text) ||
                string.IsNullOrWhiteSpace(comboBoxY.Text) ||
                string.IsNullOrWhiteSpace(comboBoxSzopy.Text) ||
                string.IsNullOrWhiteSpace(comboBoxKrokodyle.Text) ||
                string.IsNullOrWhiteSpace(comboBoxDydelfy.Text))
            {
                MessageBox.Show("Wszystkie pola muszą zostać wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!int.TryParse(comboBoxX.Text, out int x) ||
                !int.TryParse(comboBoxY.Text, out int y) ||
                !int.TryParse(comboBoxSzopy.Text, out int szopy) ||
                !int.TryParse(comboBoxKrokodyle.Text, out int krokodyle) ||
                !int.TryParse(comboBoxDydelfy.Text, out int dydelfy))
            {
                MessageBox.Show("Wszystkie pola muszą zawierać poprawne liczby.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int czas = (int)numericUpDownCzas.Value;

            int maxPol = x * y;
            int sumaZwierzat = szopy + krokodyle + dydelfy;

            if (sumaZwierzat > maxPol)
            {
                MessageBox.Show($"Łączna liczba zwierząt ({sumaZwierzat}) nie może przekraczać liczby pól planszy ({maxPol}).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.IO.File.WriteAllText("ustawienia.txt", $"{x},{y},{szopy},{krokodyle},{dydelfy},{czas}");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
