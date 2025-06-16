namespace Lab6Dydelf
{
    partial class UstawieniaForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonZAPISZUSTAWIENIA = new Button();
            comboBoxX = new ComboBox();
            comboBoxY = new ComboBox();
            comboBoxDydelfy = new ComboBox();
            comboBoxKrokodyle = new ComboBox();
            comboBoxSzopy = new ComboBox();
            label7 = new Label();
            numericUpDownCzas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCzas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 109);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 173);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 1;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 37);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Plansza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 60);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Dydelfy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 129);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Krokodyle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 288);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 5;
            label6.Text = "Czas";
            // 
            // buttonZAPISZUSTAWIENIA
            // 
            buttonZAPISZUSTAWIENIA.Location = new Point(277, 396);
            buttonZAPISZUSTAWIENIA.Name = "buttonZAPISZUSTAWIENIA";
            buttonZAPISZUSTAWIENIA.Size = new Size(198, 29);
            buttonZAPISZUSTAWIENIA.TabIndex = 11;
            buttonZAPISZUSTAWIENIA.Text = "ZAPISZ USTAWIENIA";
            buttonZAPISZUSTAWIENIA.UseVisualStyleBackColor = true;
            buttonZAPISZUSTAWIENIA.Click += buttonZAPISZUSTAWIENIA_Click;
            // 
            // comboBoxX
            // 
            comboBoxX.FormattingEnabled = true;
            comboBoxX.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxX.Location = new Point(96, 101);
            comboBoxX.Name = "comboBoxX";
            comboBoxX.Size = new Size(151, 28);
            comboBoxX.TabIndex = 12;
            // 
            // comboBoxY
            // 
            comboBoxY.FormattingEnabled = true;
            comboBoxY.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxY.Location = new Point(96, 165);
            comboBoxY.Name = "comboBoxY";
            comboBoxY.Size = new Size(151, 28);
            comboBoxY.TabIndex = 13;
            // 
            // comboBoxDydelfy
            // 
            comboBoxDydelfy.FormattingEnabled = true;
            comboBoxDydelfy.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBoxDydelfy.Location = new Point(374, 98);
            comboBoxDydelfy.Name = "comboBoxDydelfy";
            comboBoxDydelfy.Size = new Size(151, 28);
            comboBoxDydelfy.TabIndex = 14;
            // 
            // comboBoxKrokodyle
            // 
            comboBoxKrokodyle.FormattingEnabled = true;
            comboBoxKrokodyle.Items.AddRange(new object[] { "0", "1" });
            comboBoxKrokodyle.Location = new Point(374, 165);
            comboBoxKrokodyle.Name = "comboBoxKrokodyle";
            comboBoxKrokodyle.Size = new Size(151, 28);
            comboBoxKrokodyle.TabIndex = 15;
            // 
            // comboBoxSzopy
            // 
            comboBoxSzopy.FormattingEnabled = true;
            comboBoxSzopy.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8" });
            comboBoxSzopy.Location = new Point(374, 237);
            comboBoxSzopy.Name = "comboBoxSzopy";
            comboBoxSzopy.Size = new Size(151, 28);
            comboBoxSzopy.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 205);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 17;
            label7.Text = "Szopy";
            // 
            // numericUpDownCzas
            // 
            numericUpDownCzas.Location = new Point(157, 288);
            numericUpDownCzas.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDownCzas.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownCzas.Name = "numericUpDownCzas";
            numericUpDownCzas.Size = new Size(150, 27);
            numericUpDownCzas.TabIndex = 18;
            numericUpDownCzas.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // UstawieniaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 520);
            Controls.Add(numericUpDownCzas);
            Controls.Add(label7);
            Controls.Add(comboBoxSzopy);
            Controls.Add(comboBoxKrokodyle);
            Controls.Add(comboBoxDydelfy);
            Controls.Add(comboBoxY);
            Controls.Add(comboBoxX);
            Controls.Add(buttonZAPISZUSTAWIENIA);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UstawieniaForm";
            Text = "UstawieniaForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCzas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonZAPISZUSTAWIENIA;
        private ComboBox comboBoxX;
        private ComboBox comboBoxY;
        private ComboBox comboBoxDydelfy;
        private ComboBox comboBoxKrokodyle;
        private ComboBox comboBoxSzopy;
        private Label label7;
        private NumericUpDown numericUpDownCzas;
    }
}