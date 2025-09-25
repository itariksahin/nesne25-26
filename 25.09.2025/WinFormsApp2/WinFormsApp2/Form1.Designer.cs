namespace WinFormsApp2
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Etiket Fiyatı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 16);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Secilen ürün sayısı:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 50);
            button1.Name = "button1";
            button1.Size = new Size(84, 66);
            button1.TabIndex = 4;
            button1.Text = "%10 indirim";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(116, 50);
            button2.Name = "button2";
            button2.Size = new Size(82, 66);
            button2.TabIndex = 5;
            button2.Text = "%20 indirim";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(204, 52);
            button3.Name = "button3";
            button3.Size = new Size(80, 64);
            button3.TabIndex = 6;
            button3.Text = "%25 indirim";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.ForeColor = Color.White;
            button4.Location = new Point(290, 54);
            button4.Name = "button4";
            button4.Size = new Size(82, 62);
            button4.TabIndex = 7;
            button4.Text = "%30  indirim";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.ForeColor = Color.Yellow;
            button5.Location = new Point(378, 54);
            button5.Name = "button5";
            button5.Size = new Size(86, 62);
            button5.TabIndex = 8;
            button5.Text = "%40 indirim";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 137);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 9;
            label3.Text = "TOPLAM FİYAT:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            button6.Location = new Point(470, 56);
            button6.Name = "button6";
            button6.Size = new Size(94, 58);
            button6.TabIndex = 11;
            button6.Text = "SİL";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 281);
            Controls.Add(button6);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label3;
        private TextBox textBox3;
        private Button button6;
    }
}
