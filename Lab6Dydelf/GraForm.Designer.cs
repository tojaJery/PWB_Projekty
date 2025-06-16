namespace Lab6Dydelf
{
    partial class GraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public class UstawieniaGry
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Czas { get; set; }
            public int Dydelfy { get; set; }
            public int Szopy { get; set; }
            public int Krokodyle { get; set; }
        }
        public UstawieniaGry Ustawienia { get; set; }
        
        
        private void LoadSettings()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("ustawienia.txt");
                if (lines.Length > 0)
                {
                    string[] settings = lines[0].Split(',');
                    Ustawienia.X = int.Parse(settings[0]);
                    Ustawienia.Y = int.Parse(settings[1]);
                    Ustawienia.Szopy = int.Parse(settings[2]);
                    Ustawienia.Krokodyle = int.Parse(settings[3]);
                    Ustawienia.Dydelfy = int.Parse(settings[4]);
                    Ustawienia.Czas = int.Parse(settings[5]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd wczytywania ustawień: {ex.Message}");
            }
        }
        private Dictionary<Point, TypZawartosci> zawartoscPlanszy;
        private void StworzPlansze()
        {
            panelPlansza.Controls.Clear();
            zawartoscPlanszy = new Dictionary<Point, TypZawartosci>();
             
            if(Ustawienia == null)
            {
                Ustawienia = new UstawieniaGry
                {
                    X = 10,
                    Y = 10,
                    Dydelfy = 3,
                    Szopy = 2,
                    Krokodyle = 1,
                    Czas = 60
                };
            }

            int odstęp = 2; 

            
            int maxSzerokosc = panelPlansza.Width - (Ustawienia.X - 1) * odstęp;
            int maxWysokosc = panelPlansza.Height - (Ustawienia.Y - 1) * odstęp;

            int rozmiarSzerokosc = maxSzerokosc / Ustawienia.X;
            int rozmiarWysokosc = maxWysokosc / Ustawienia.Y;

            
            int rozmiarPrzycisku = Math.Min(rozmiarSzerokosc, rozmiarWysokosc);

            for (int y = 0; y < Ustawienia.Y; y++)
            {
                for (int x = 0; x < Ustawienia.X; x++)
                {
                    Button btn = new Button();
                    btn.Width = rozmiarPrzycisku;
                    btn.Height = rozmiarPrzycisku;
                    btn.Left = x * (rozmiarPrzycisku + odstęp);
                    btn.Top = y * (rozmiarPrzycisku + odstęp);
                    btn.BackColor = Color.Gray;
                    btn.Tag = new Point(x, y);
                    btn.Click += Pole_Click;

                    panelPlansza.Controls.Add(btn);
                }
            }



            for (int y = 0; y < Ustawienia.Y; y++)
            {
                for (int x = 0; x < Ustawienia.X; x++)
                {
                    Button btn = new Button();
                    btn.Width = rozmiarPrzycisku;
                    btn.Height = rozmiarPrzycisku;
                    btn.Left = x * (rozmiarPrzycisku + odstęp);
                    btn.Top = y * (rozmiarPrzycisku + odstęp);
                    btn.BackColor = Color.Gray;
                    btn.Tag = new Point(x, y);
                    btn.Click += Pole_Click;

                    panelPlansza.Controls.Add(btn);
                }
            }
            for (int y = 0; y < Ustawienia.Y; y++)
            {
                for (int x = 0; x < Ustawienia.X; x++)
                {
                    Point p = new Point(x, y);
                    if (!zawartoscPlanszy.ContainsKey(p))
                    {
                        zawartoscPlanszy[p] = TypZawartosci.Puste;
                    }
                }
            }
            RozmiescZwierzęta();
            czasPozostaly = Ustawienia.Czas;
            graTimer = new System.Windows.Forms.Timer();

            graTimer.Interval = 1000;
            graTimer.Tick += (s, e) =>
            {
                czasPozostaly--;
                labelTimer.Text = $"{czasPozostaly} s";
                if (czasPozostaly <= 0)
                {
                    graTimer.Stop();
                    ZakonczGre(false, "Czas się skończył!");
                }
            };
            // graTimer.Start();
            labelTimer.Text = $"{czasPozostaly} s";
        }
        private void RozmiescZwierzęta()
        {
            Random rng = new Random();
            List<Point> wszystkiePozycje = zawartoscPlanszy.Keys.ToList();

            void Rozmiesc(int ile, TypZawartosci typ)
            {
                for (int i = 0; i < ile; i++)
                {
                    if (wszystkiePozycje.Count == 0) break;

                    int indeks = rng.Next(wszystkiePozycje.Count);
                    Point wybranaPoz = wszystkiePozycje[indeks];
                    wszystkiePozycje.RemoveAt(indeks);

                    zawartoscPlanszy[wybranaPoz] = typ;
                }
            }

            Rozmiesc(Ustawienia.Dydelfy, TypZawartosci.Dydelf);
            Rozmiesc(Ustawienia.Szopy, TypZawartosci.Szop);
            Rozmiesc(Ustawienia.Krokodyle, TypZawartosci.Krokodyl);
        }
        private bool graRozpoczeta = false;
        private void Pole_Click(object sender, EventArgs e)
        {
            Button klikniety = sender as Button;
            Point poz = (Point)klikniety.Tag;

            if (!graRozpoczeta)
            {
                graRozpoczeta = true;
                graTimer.Start();
            }

            if (!zawartoscPlanszy.ContainsKey(poz))
                return;

            TypZawartosci zawartosc = zawartoscPlanszy[poz];

            switch (zawartosc)
            {
                case TypZawartosci.Puste:
                    klikniety.BackColor = Color.LightGray;
                    klikniety.Enabled = false;
                    break;
                case TypZawartosci.Dydelf:
                    klikniety.BackColor = Color.Yellow;
                    klikniety.Text = "D";
                    klikniety.Enabled = false;

                    int odkryteDydelfy = panelPlansza.Controls.OfType<Button>()
                        .Count(b => b.Text == "D");

                    if (odkryteDydelfy == Ustawienia.Dydelfy)
                    {
                        graTimer?.Stop();
                        ZakonczGre(true, "Znalazłeś wszystkie Dydelfy!");
                    }

                    break;
                case TypZawartosci.Szop:
                    klikniety.BackColor = Color.Brown;
                    klikniety.Text = "S";
                    klikniety.Enabled = false;
                    System.Windows.Forms.Timer szopTimer = new System.Windows.Forms.Timer();
                    szopTimer.Interval = 2000;
                    szopTimer.Tick += (s, args) =>
                    {
                        szopTimer.Stop();
                        ZakryjSzopaIZnajomych(poz);
                    };
                    szopTimer.Start();
                    break;

                case TypZawartosci.Krokodyl:
                    klikniety.BackColor = Color.Green;
                    klikniety.Text = "K";
                    System.Windows.Forms.Timer krokTimer = new System.Windows.Forms.Timer();
                    krokTimer.Interval = 2000;
                    krokTimer.Tick += (s, args) =>
                    {
                        krokTimer.Stop();
                        if (klikniety.Text == "K") 
                        {
                            ZakonczGre(false, "Zaatakował Cię krokodyl!");
                        }
                    };
                    krokTimer.Start();

                    klikniety.Click -= Pole_Click;
                    klikniety.Click += (s2, e2) =>
                    {
                        klikniety.Text = "";
                        klikniety.BackColor = Color.Gray;
                        klikniety.Click -= (s2 as EventHandler);
                    };
                    break;

            }
        }
        private void ZakryjSzopaIZnajomych(Point poz)
        {
            List<Point> sasiedzi = new List<Point>
    {
        new Point(poz.X - 1, poz.Y),
        new Point(poz.X + 1, poz.Y),
        new Point(poz.X, poz.Y - 1),
        new Point(poz.X, poz.Y + 1)
    };

            foreach (Control ctrl in panelPlansza.Controls)
            {
                if (ctrl is Button btn && btn.Tag is Point p)
                {
                    if (p == poz || sasiedzi.Contains(p))
                    {
                        btn.Text = "";
                        btn.BackColor = Color.Gray;
                        btn.Enabled = true;
                    }
                }
            }
        }
        private void ZakonczGre(bool wygrana, string komunikat)
        {
            foreach (Control ctrl in panelPlansza.Controls)
            {
                ctrl.Enabled = false;
            }

            MessageBox.Show(komunikat, wygrana ? "Wygrana" : "Przegrana");

            
            this.Close();
        }
        System.Windows.Forms.Timer graTimer = new System.Windows.Forms.Timer();

        private int czasPozostaly;


        public enum TypZawartosci
        {
            Puste,
            Dydelf,
            Szop,
            Krokodyl
        }






        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPlansza = new Panel();
            label1 = new Label();
            labelTimer = new Label();
            SuspendLayout();
            // 
            // panelPlansza
            // 
            panelPlansza.Location = new Point(134, 55);
            panelPlansza.Name = "panelPlansza";
            panelPlansza.Size = new Size(660, 370);
            panelPlansza.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 465);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Pozostały czas:";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(233, 465);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(50, 20);
            labelTimer.TabIndex = 2;
            labelTimer.Text = "label2";
            labelTimer.Click += labelTimer_Click;
            // 
            // GraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 539);
            Controls.Add(labelTimer);
            Controls.Add(label1);
            Controls.Add(panelPlansza);
            Name = "GraForm";
            Text = "GraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPlansza;
        private Label label1;
        private Label labelTimer;
        

    }
}