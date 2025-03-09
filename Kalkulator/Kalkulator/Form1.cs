using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double a, b;
        bool a_used = false;


        public Form1()
        {
            InitializeComponent();
            
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "1";
        }

        private void DIVISION_Click(object sender, EventArgs e)
        {
            a = double.Parse(NUMBERBOX.Text, System.Globalization.CultureInfo.InvariantCulture);
            a_used = true;
            NUMBERBOX.Text = "";
            OPERATION.Text = "/";

        }

        private void DELETEONE_Click(object sender, EventArgs e)
        {
            if (NUMBERBOX.Text.Length > 0)
            {
                NUMBERBOX.Text = NUMBERBOX.Text.Remove(NUMBERBOX.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NUMBERBOX.Text = NUMBERBOX.Text + "0";
        }

        private void COMMA_Click(object sender, EventArgs e)
        {
            if (!NUMBERBOX.Text.Contains("."))
            {
                if (NUMBERBOX.Text == "")
                {
                    NUMBERBOX.Text = NUMBERBOX.Text + "0.";
                }
                else
                {
                    NUMBERBOX.Text = NUMBERBOX.Text + ".";
                }
            }
            
        }

        private void DELETEALL_Click(object sender, EventArgs e)
        {
            
            NUMBERBOX.Text = "";
            OPERATION.Text = "";
            a = 0;
            b = 0;
            a_used = false;
            RESULT.Text = "";
        }

        private void PLUS_Click(object sender, EventArgs e)
        {
            if (NUMBERBOX.Text != "")
            {
                a = double.Parse(NUMBERBOX.Text, System.Globalization.CultureInfo.InvariantCulture);
                a_used = true;
                NUMBERBOX.Text = "";
                OPERATION.Text = "+";
            }
        }

        private void MINUS_Click(object sender, EventArgs e)
        {
            if(NUMBERBOX.Text != "")
            {
                a = double.Parse(NUMBERBOX.Text, System.Globalization.CultureInfo.InvariantCulture);
                a_used = true;
                NUMBERBOX.Text = "";
                OPERATION.Text = "-";
            }
            
        }

        private void MULTIPLICATION_Click(object sender, EventArgs e)
        {
            if (NUMBERBOX.Text != "")
            {
                a = double.Parse(NUMBERBOX.Text, System.Globalization.CultureInfo.InvariantCulture);
                a_used = true;
                NUMBERBOX.Text = "";
                OPERATION.Text = "x";
            }
        }

        private void EQUAL_Click(object sender, EventArgs e)
        {
            string result = "";
            if (a_used == false)
            {
                if(NUMBERBOX.Text == "")
                {
                    RESULT.Text = "WprowadŸ liczbê";
                }
                else
                {
                    result = NUMBERBOX.Text;
                }
                
            }
            switch (OPERATION.Text)
            {
                case "+":
                    b = double.Parse(NUMBERBOX.Text, System.Globalization.CultureInfo.InvariantCulture);
                    result = (a + b).ToString();
                    break;
                case "-":
                    b = double.Parse(NUMBERBOX.Text, System.Globalization.CultureInfo.InvariantCulture);
                    result = (a - b).ToString();
                    break;
                case "x":
                    b = double.Parse(NUMBERBOX.Text, System.Globalization.CultureInfo.InvariantCulture);
                    result = (a * b).ToString();
                    break;
                case "/":
                    b = double.Parse(NUMBERBOX.Text, System.Globalization.CultureInfo.InvariantCulture);
                    if (b == 0)
                    {
                        RESULT.Text = "Nie mo¿na dzieliæ przez 0";
                    }
                    else
                    {
                        result = (a / b).ToString();
                    }
                    break;
            }
            
            RESULT.Text = result.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        private void RESULT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
