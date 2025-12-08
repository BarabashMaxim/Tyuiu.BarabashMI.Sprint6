namespace Tyuiu.BarabashMI.Sprint6.Task0.V8
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            textBoxVarA = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBoxResult = new TextBox();
            button1 = new Button();
            but2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(776, 198);
            textBox1.TabIndex = 0;
            textBox1.Text = "Вычислить выражение по формуле:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(12, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(61, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://lh7-us.googleusercontent.com/IqwzvDJtfdhO5l3OQuLyWOFoSGW_ihtK6EyVxL_qVKfSV0KAch6XK4UDxgjUHGBu9tzUF1CZ1IL0KhB4v0T4h-46eJQbg2oz6nBmOGg_6ZUY6hsIMFhcIiuBVPVO4diKOB07SBs0G6bU6gloFCggOkE";
            pictureBox1.Location = new Point(633, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 77);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBoxVarA
            // 
            textBoxVarA.Location = new Point(35, 297);
            textBoxVarA.Name = "textBoxVarA";
            textBoxVarA.Size = new Size(100, 23);
            textBoxVarA.TabIndex = 3;
            textBoxVarA.TextChanged += textBox3_TextChanged;
            textBoxVarA.KeyPress += textBoxVarA_KeyPress;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Location = new Point(26, 266);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(119, 67);
            textBox4.TabIndex = 4;
            textBox4.Text = "Переменная x";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.Location = new Point(586, 266);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 67);
            textBox5.TabIndex = 5;
            textBox5.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.Location = new Point(607, 297);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 6;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(550, 379);
            button1.Name = "button1";
            button1.Size = new Size(41, 38);
            button1.TabIndex = 7;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttomHelp_Click;
            // 
            // but2
            // 
            but2.Location = new Point(597, 381);
            but2.Name = "but2";
            but2.Size = new Size(130, 34);
            but2.TabIndex = 8;
            but2.Text = "Выполнить";
            but2.UseVisualStyleBackColor = true;
            but2.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 429);
            Controls.Add(but2);
            Controls.Add(button1);
            Controls.Add(textBoxResult);
            Controls.Add(textBox5);
            Controls.Add(textBoxVarA);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint6 | Task0 | V8 | BarabashMI";
            Load += buttonDone_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private TextBox textBoxVarA;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBoxResult;
        private Button button1;
        private Button but2;
    }
}
