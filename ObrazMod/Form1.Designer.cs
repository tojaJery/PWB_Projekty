namespace ObrazMod
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
            pictureBox1 = new PictureBox();
            buttonLoad = new Button();
            buttonOnlyGreen = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(370, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 361);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(96, 343);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(133, 62);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonOnlyGreen
            // 
            buttonOnlyGreen.BackColor = Color.FromArgb(128, 255, 128);
            buttonOnlyGreen.Location = new Point(96, 279);
            buttonOnlyGreen.Name = "buttonOnlyGreen";
            buttonOnlyGreen.Size = new Size(133, 58);
            buttonOnlyGreen.TabIndex = 2;
            buttonOnlyGreen.Text = "Only Green";
            buttonOnlyGreen.UseVisualStyleBackColor = false;
            buttonOnlyGreen.Click += buttonOnlyGreen_Click;
            // 
            // button1
            // 
            button1.Location = new Point(96, 224);
            button1.Name = "button1";
            button1.Size = new Size(133, 49);
            button1.TabIndex = 3;
            button1.Text = "Invert Colors";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonOnlyGreen);
            Controls.Add(buttonLoad);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonLoad;
        private Button buttonOnlyGreen;
        private Button button1;
    }
}
