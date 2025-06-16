namespace Lab6Dydelf
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
            label1 = new Label();
            buttonSTART = new Button();
            buttonUSTAWIENIA = new Button();
            buttonKONIEC = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(42, 62);
            label1.Name = "label1";
            label1.Size = new Size(437, 45);
            label1.TabIndex = 0;
            label1.Text = "GDZIE JEST DYDELF";
            // 
            // buttonSTART
            // 
            buttonSTART.Location = new Point(166, 158);
            buttonSTART.Name = "buttonSTART";
            buttonSTART.Size = new Size(166, 60);
            buttonSTART.TabIndex = 1;
            buttonSTART.Text = "START";
            buttonSTART.UseVisualStyleBackColor = true;
            buttonSTART.Click += buttonSTART_Click;
            // 
            // buttonUSTAWIENIA
            // 
            buttonUSTAWIENIA.Location = new Point(166, 249);
            buttonUSTAWIENIA.Name = "buttonUSTAWIENIA";
            buttonUSTAWIENIA.Size = new Size(166, 64);
            buttonUSTAWIENIA.TabIndex = 2;
            buttonUSTAWIENIA.Text = "USTAWIENIA";
            buttonUSTAWIENIA.UseVisualStyleBackColor = true;
            buttonUSTAWIENIA.Click += buttonUSTAWIENIA_Click;
            // 
            // buttonKONIEC
            // 
            buttonKONIEC.Location = new Point(166, 352);
            buttonKONIEC.Name = "buttonKONIEC";
            buttonKONIEC.Size = new Size(166, 64);
            buttonKONIEC.TabIndex = 3;
            buttonKONIEC.Text = "KONIEC";
            buttonKONIEC.UseVisualStyleBackColor = true;
            buttonKONIEC.Click += buttonKONIEC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 539);
            Controls.Add(buttonKONIEC);
            Controls.Add(buttonUSTAWIENIA);
            Controls.Add(buttonSTART);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonSTART;
        private Button buttonUSTAWIENIA;
        private Button buttonKONIEC;
    }
}
