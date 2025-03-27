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
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            buttonUpsideDown = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
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
            buttonLoad.Location = new Point(96, 408);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(96, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(80, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "270deg";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(16, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "180deg";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "90deg";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(96, 171);
            button2.Name = "button2";
            button2.Size = new Size(133, 47);
            button2.TabIndex = 5;
            button2.Text = "Rotate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonUpsideDown
            // 
            buttonUpsideDown.Location = new Point(98, 343);
            buttonUpsideDown.Name = "buttonUpsideDown";
            buttonUpsideDown.Size = new Size(131, 59);
            buttonUpsideDown.TabIndex = 6;
            buttonUpsideDown.Text = "Upside-down";
            buttonUpsideDown.UseVisualStyleBackColor = true;
            buttonUpsideDown.Click += buttonUpsideDown_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(buttonUpsideDown);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(buttonOnlyGreen);
            Controls.Add(buttonLoad);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonLoad;
        private Button buttonOnlyGreen;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private Button buttonUpsideDown;
    }
}
