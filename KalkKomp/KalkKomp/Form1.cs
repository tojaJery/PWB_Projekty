namespace KalkKomp
{
    public partial class Form1 : Form
    {
        private Form2 secondForm = new Form2();
        private Form3 thirdForm = new Form3();
        private int cenaKomputer = 0;
        private int cenaMonitor = 0;

        public Form1()
        {
            InitializeComponent();

            secondForm.OnCenaZmieniona += AktualizujCeneKomputera;
            thirdForm.OnCenaMonitorZmieniona += AktualizujCeneMonitora;
        }

        private void buttonKomputer_Click(object sender, EventArgs e)
        {
            secondForm.Show();
            secondForm.BringToFront();
        }

        private void buttonMonitor_Click(object sender, EventArgs e)
        {
            thirdForm.Show();
            thirdForm.BringToFront();
        }

        private void AktualizujCeneKomputera(int cenaK)
        {
            cenaKomputer = cenaK;
            AktualizujCalkowitaCene();
        }

        private void AktualizujCeneMonitora(int cenaM)
        {
            cenaMonitor = cenaM;
            AktualizujCalkowitaCene();
        }

        private void AktualizujCalkowitaCene()
        {
            int suma = cenaKomputer + cenaMonitor;
            CenaAll.Text = suma.ToString() + " z³";
        }
    }
}
