using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc;
            double sayi1=Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sayi3 = Convert.ToDouble(textBox3.Text);
            double sayi4 = Convert.ToDouble(textBox4.Text);
            double sayi5 = Convert.ToDouble(textBox5.Text);
            sonuc = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5;
            textBox6.Text=Convert.ToString(sonuc);
        }
    }
}
