namespace Lab6Dydelf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKONIEC_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void buttonUSTAWIENIA_Click(object sender, EventArgs e)
        {
            // Create an instance of UstawieniaForm
            UstawieniaForm ustawieniaForm = new UstawieniaForm();
            // Show the UstawieniaForm as a dialog
            if (ustawieniaForm.ShowDialog() == DialogResult.OK)
            {
                // If the dialog result is OK, you can handle any post-dialog logic here
                // For example, you might want to refresh some data or update the UI

            }
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            // Create an instance of GraForm
            GraForm graForm = new();
            // Show the GraForm as a dialog
            if (graForm.ShowDialog() == DialogResult.OK)
            {
                // If the dialog result is OK, you can handle any post-dialog logic here
                // For example, you might want to refresh some data or update the UI

            }
        }
    }
}
