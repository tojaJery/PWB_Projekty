namespace ArkuszKalk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Imię = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            Wiek = new DataGridViewTextBoxColumn();
            Stanowisko = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            XMLButton = new Button();
            DeserializeXML = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Imię, Nazwisko, Wiek, Stanowisko });
            dataGridView1.Location = new Point(42, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(597, 188);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Imię
            // 
            Imię.HeaderText = "Imie";
            Imię.MinimumWidth = 6;
            Imię.Name = "Imię";
            Imię.Width = 125;
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.MinimumWidth = 6;
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Width = 125;
            // 
            // Wiek
            // 
            Wiek.HeaderText = "Wiek";
            Wiek.MinimumWidth = 6;
            Wiek.Name = "Wiek";
            Wiek.Width = 125;
            // 
            // Stanowisko
            // 
            Stanowisko.HeaderText = "Stanowisko";
            Stanowisko.MinimumWidth = 6;
            Stanowisko.Name = "Stanowisko";
            Stanowisko.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(179, 289);
            button1.Name = "button1";
            button1.Size = new Size(94, 67);
            button1.TabIndex = 1;
            button1.Text = "Zapis do CSV";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(294, 289);
            button2.Name = "button2";
            button2.Size = new Size(94, 67);
            button2.TabIndex = 2;
            button2.Text = "Odczyt z CSV";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(674, 170);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(674, 228);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Usuń";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // XMLButton
            // 
            XMLButton.Location = new Point(404, 289);
            XMLButton.Name = "XMLButton";
            XMLButton.Size = new Size(99, 67);
            XMLButton.TabIndex = 5;
            XMLButton.Text = "Serializuj XML";
            XMLButton.UseVisualStyleBackColor = true;
            XMLButton.Click += XMLButton_Click;
            // 
            // DeserializeXML
            // 
            DeserializeXML.Location = new Point(404, 362);
            DeserializeXML.Name = "DeserializeXML";
            DeserializeXML.Size = new Size(99, 63);
            DeserializeXML.TabIndex = 6;
            DeserializeXML.Text = "Deserializuj XML";
            DeserializeXML.UseVisualStyleBackColor = true;
            DeserializeXML.Click += DeserializeXML_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeserializeXML);
            Controls.Add(XMLButton);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Imię;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn Wiek;
        private DataGridViewTextBoxColumn Stanowisko;
        private Button XMLButton;
        private Button DeserializeXML;
    }
}
