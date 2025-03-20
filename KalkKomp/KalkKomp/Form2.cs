using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KalkKomp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        public event Action<int> OnCenaZmieniona;
        private Dictionary<string, int> cenyProcesorow = new Dictionary<string, int>
        {
            { "Procesor1", 500 },
            { "Procesor2", 800 },
            { "Procesor3", 1200 },
            { "Procesor4", 1600 }
        };
        int cenaProcesora = 0;
        int cenaPamieci = 0;
        const int cenaReszta = 1000;
        int cenaSuma = 0;

        private void InitializeComboBox()
        {
            if (comboBox1 != null) // Sprawdzenie, czy ComboBox istnieje
            {
                comboBox1.Items.AddRange(cenyProcesorow.Keys.ToArray());
                comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            }
            else
            {
                MessageBox.Show("Błąd: comboBox1 nie został poprawnie zainicjalizowany.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string wybranyProcesor = comboBox1.SelectedItem.ToString();
                label2.Text = cenyProcesorow[wybranyProcesor].ToString() + " zł";
                cenaProcesora = cenyProcesorow[wybranyProcesor];
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "500 zł";
            cenaPamieci = 500;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "800 zł";
            cenaPamieci = 800;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "1200 zł";
            cenaPamieci = 1200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cenaSuma = cenaProcesora + cenaPamieci + cenaReszta;
            OnCenaZmieniona?.Invoke(cenaSuma);
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

