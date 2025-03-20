namespace KalkKomp
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
            buttonKomputer = new Button();
            buttonMonitor = new Button();
            label1 = new Label();
            CenaAll = new Label();
            SuspendLayout();
            // 
            // buttonKomputer
            // 
            buttonKomputer.Location = new Point(156, 123);
            buttonKomputer.Name = "buttonKomputer";
            buttonKomputer.Size = new Size(133, 67);
            buttonKomputer.TabIndex = 0;
            buttonKomputer.Text = "Komputer";
            buttonKomputer.UseVisualStyleBackColor = true;
            buttonKomputer.Click += buttonKomputer_Click;
            // 
            // buttonMonitor
            // 
            buttonMonitor.Location = new Point(295, 123);
            buttonMonitor.Name = "buttonMonitor";
            buttonMonitor.Size = new Size(150, 67);
            buttonMonitor.TabIndex = 1;
            buttonMonitor.Text = "Monitor";
            buttonMonitor.UseVisualStyleBackColor = true;
            buttonMonitor.Click += buttonMonitor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(451, 138);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 2;
            label1.Text = "Cena [zł]";
            // 
            // CenaAll
            // 
            CenaAll.AutoSize = true;
            CenaAll.BackColor = SystemColors.ControlLightLight;
            CenaAll.Font = new Font("Segoe UI", 11F);
            CenaAll.Location = new Point(567, 142);
            CenaAll.Name = "CenaAll";
            CenaAll.Size = new Size(63, 25);
            CenaAll.TabIndex = 3;
            CenaAll.Text = "0";
           // CenaAll.Click += CenaAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CenaAll);
            Controls.Add(label1);
            Controls.Add(buttonMonitor);
            Controls.Add(buttonKomputer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKomputer;
        private Button buttonMonitor;
        private Label label1;
        private Label CenaAll;
    }
}
