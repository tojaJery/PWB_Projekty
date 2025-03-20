using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkuszKalk
{
    public partial class Form2 : Form
    {
        public Rekord NowyRekord { get; set; }
        public Form2()
        {
            InitializeComponent();
            InitializeComboBox();

        }

        void InitializeComboBox()
        {
            comboBox1.Items.Add("Kierownik");
            comboBox1.Items.Add("Pracownik");
            comboBox1.Items.Add("Stażysta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rekord nowyRekord = new Rekord();
            nowyRekord.imie = textBox1.Text;
            nowyRekord.nazwisko = textBox2.Text;
            nowyRekord.wiek = Convert.ToInt32(textBox3.Text);
            nowyRekord.stanowisko = comboBox1.SelectedItem.ToString();
            NowyRekord = nowyRekord;

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
