namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = Convert.ToInt32(textBox2.Text);
            int sayi = Convert.ToInt32(textBox1.Text);
            sayi = sayi + sayac;
            textBox1.Text = Convert.ToString(sayi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayac = Convert.ToInt32(textBox2.Text);
            int sayi = Convert.ToInt32(textBox1.Text);
            sayi = sayi - sayac;
            textBox1.Text = Convert.ToString(sayi);

        }
    }
}
