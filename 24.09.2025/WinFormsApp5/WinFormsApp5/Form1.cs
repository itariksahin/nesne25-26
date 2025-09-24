namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        double sonuc = 0;
        int sec;
        Boolean ilk_islem = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            ilk_islem = true;
            sonuc = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if( sec==1) sonuc = sonuc + Convert.ToDouble(textBox1.Text);
            if (sec == 2) sonuc = sonuc - Convert.ToDouble(textBox1.Text);
            if (sec == 3) sonuc = sonuc * Convert.ToDouble(textBox1.Text);
            if (sec == 4) sonuc = sonuc / Convert.ToDouble(textBox1.Text);

            textBox1.Text = Convert.ToString(sonuc);
            ilk_islem = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ilk_islem) { sonuc = Convert.ToDouble(textBox1.Text); ilk_islem = false; }
            else
            {
                sonuc = sonuc + Convert.ToDouble(textBox1.Text);
            }
            textBox1.Text = "";
            sec = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ilk_islem) { sonuc = Convert.ToDouble(textBox1.Text); ilk_islem = false; }
            else
            {
                sonuc = sonuc - Convert.ToDouble(textBox1.Text);
            }
            textBox1.Text = "";
            sec = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {   if (ilk_islem) { sonuc = Convert.ToDouble(textBox1.Text); ilk_islem = false; }
            else
            {
                sonuc = sonuc * Convert.ToDouble(textBox1.Text);
            }
            textBox1.Text = "";
            sec = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ilk_islem) { sonuc = Convert.ToDouble(textBox1.Text); ilk_islem = false; }
            else
            {
                sonuc = sonuc / Convert.ToDouble(textBox1.Text);
            }
            textBox1.Text = "";
            sec = 4;
        }
    }
}
