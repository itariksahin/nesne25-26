namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi1 = rnd.Next(0, 20);
            int sayi2 = rnd.Next(0, 20);
            pictureBox1.Left = pictureBox1.Left + sayi1;
            pictureBox2.Left = pictureBox2.Left + sayi2;
        }
    }
}
