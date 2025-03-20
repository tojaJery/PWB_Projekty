using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KalkKomp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            InitializeListView();
        }
        int cenaMonitor = 0;
        public event Action<int> OnCenaMonitorZmieniona;
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private Dictionary<string, int> cenyMonitorow = new Dictionary<string, int>
{
        { "Monitor1", 700 },
        { "Monitor2", 1200 },
        { "Monitor3", 1800 }
        };
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Model", 120);
            listView1.Columns.Add("Cena", 80);

            foreach (var monitor in cenyMonitorow)
            {
                ListViewItem item = new ListViewItem(monitor.Key);
                item.SubItems.Add(monitor.Value.ToString() + " zł");
                listView1.Items.Add(item);
            }

            listView1.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string wybranyMonitor = listView1.SelectedItems[0].Text;
                label2.Text = cenyMonitorow[wybranyMonitor].ToString();
                cenaMonitor = cenyMonitorow[wybranyMonitor];

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnCenaMonitorZmieniona?.Invoke(cenaMonitor);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
