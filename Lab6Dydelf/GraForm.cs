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
    public partial class GraForm : Form
    {
        public GraForm()
        {
            InitializeComponent();
            Ustawienia = new UstawieniaGry();
            LoadSettings();
            StworzPlansze();
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
