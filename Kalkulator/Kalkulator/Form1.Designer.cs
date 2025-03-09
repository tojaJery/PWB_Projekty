namespace Kalkulator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            DIVISION = new Button();
            DELETEONE = new Button();
            PLUS = new Button();
            MINUS = new Button();
            MULTIPLICATION = new Button();
            EQUAL = new Button();
            DELETEALL = new Button();
            COMMA = new Button();
            NUMBERBOX = new TextBox();
            OPERATION = new TextBox();
            RESULT = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(219, 132);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(319, 132);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(419, 132);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(219, 167);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(319, 167);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(419, 164);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(219, 202);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(319, 202);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(419, 199);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(219, 237);
            button0.Name = "button0";
            button0.Size = new Size(94, 29);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // DIVISION
            // 
            DIVISION.Location = new Point(419, 269);
            DIVISION.Name = "DIVISION";
            DIVISION.Size = new Size(94, 67);
            DIVISION.TabIndex = 10;
            DIVISION.Text = "/";
            DIVISION.UseVisualStyleBackColor = true;
            DIVISION.Click += DIVISION_Click;
            // 
            // DELETEONE
            // 
            DELETEONE.Location = new Point(419, 234);
            DELETEONE.Name = "DELETEONE";
            DELETEONE.Size = new Size(94, 29);
            DELETEONE.TabIndex = 11;
            DELETEONE.Text = "DELETE";
            DELETEONE.UseVisualStyleBackColor = true;
            DELETEONE.Click += DELETEONE_Click;
            // 
            // PLUS
            // 
            PLUS.Location = new Point(219, 272);
            PLUS.Name = "PLUS";
            PLUS.Size = new Size(94, 64);
            PLUS.TabIndex = 12;
            PLUS.Text = "+";
            PLUS.UseVisualStyleBackColor = true;
            PLUS.Click += PLUS_Click;
            // 
            // MINUS
            // 
            MINUS.Location = new Point(319, 272);
            MINUS.Name = "MINUS";
            MINUS.Size = new Size(94, 64);
            MINUS.TabIndex = 13;
            MINUS.Text = "-";
            MINUS.UseVisualStyleBackColor = true;
            MINUS.Click += MINUS_Click;
            // 
            // MULTIPLICATION
            // 
            MULTIPLICATION.Location = new Point(519, 269);
            MULTIPLICATION.Name = "MULTIPLICATION";
            MULTIPLICATION.Size = new Size(94, 67);
            MULTIPLICATION.TabIndex = 14;
            MULTIPLICATION.Text = "x";
            MULTIPLICATION.UseVisualStyleBackColor = true;
            MULTIPLICATION.Click += MULTIPLICATION_Click;
            // 
            // EQUAL
            // 
            EQUAL.Location = new Point(519, 199);
            EQUAL.Name = "EQUAL";
            EQUAL.Size = new Size(94, 67);
            EQUAL.TabIndex = 15;
            EQUAL.Text = "=";
            EQUAL.UseVisualStyleBackColor = true;
            EQUAL.Click += EQUAL_Click;
            // 
            // DELETEALL
            // 
            DELETEALL.Location = new Point(519, 129);
            DELETEALL.Name = "DELETEALL";
            DELETEALL.Size = new Size(94, 67);
            DELETEALL.TabIndex = 16;
            DELETEALL.Text = "C";
            DELETEALL.UseVisualStyleBackColor = true;
            DELETEALL.Click += DELETEALL_Click;
            // 
            // COMMA
            // 
            COMMA.Location = new Point(319, 237);
            COMMA.Name = "COMMA";
            COMMA.Size = new Size(94, 29);
            COMMA.TabIndex = 17;
            COMMA.Text = ",";
            COMMA.UseVisualStyleBackColor = true;
            COMMA.Click += COMMA_Click;
            // 
            // NUMBERBOX
            // 
            NUMBERBOX.Location = new Point(219, 66);
            NUMBERBOX.Name = "NUMBERBOX";
            NUMBERBOX.Size = new Size(294, 27);
            NUMBERBOX.TabIndex = 18;
            // 
            // OPERATION
            // 
            OPERATION.Location = new Point(519, 66);
            OPERATION.Name = "OPERATION";
            OPERATION.Size = new Size(94, 27);
            OPERATION.TabIndex = 19;
            // 
            // RESULT
            // 
            RESULT.Location = new Point(275, 99);
            RESULT.Name = "RESULT";
            RESULT.Size = new Size(338, 27);
            RESULT.TabIndex = 20;
            RESULT.TextChanged += RESULT_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 102);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 21;
            label1.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(RESULT);
            Controls.Add(OPERATION);
            Controls.Add(NUMBERBOX);
            Controls.Add(COMMA);
            Controls.Add(DELETEALL);
            Controls.Add(EQUAL);
            Controls.Add(MULTIPLICATION);
            Controls.Add(MINUS);
            Controls.Add(PLUS);
            Controls.Add(DELETEONE);
            Controls.Add(DIVISION);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button DIVISION;
        private Button DELETEONE;
        private Button PLUS;
        private Button MINUS;
        private Button MULTIPLICATION;
        private Button EQUAL;
        private Button DELETEALL;
        private Button COMMA;
        private TextBox NUMBERBOX;
        private TextBox OPERATION;
        private TextBox RESULT;
        private Label label1;
    }
}
