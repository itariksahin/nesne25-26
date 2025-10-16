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
           double sayi_1=Convert.ToDouble(textBox1.Text);
           double sayi_2=Convert.ToDouble(textBox2.Text);
           double sonuc=0;
            if (sayi_1 > 100) { MessageBox.Show("1. Yazýlý notu 100 den büyük olamaz"); }
            if(sayi_2>100) { MessageBox.Show("2. Yazýlý notu 100 den büyük olamaz"); }
            if (sayi_1 < 101 && sayi_2 < 101) {sonuc = (sayi_1 + sayi_2) / 2; }
            if (sonuc < 50) { label3.Text = "Sonuc: " + Convert.ToString(sonuc) + " Sýnýfta kaldý"; }
            if (sonuc >= 50) { label3.Text = "Sonuc: " + Convert.ToString(sonuc) + " Sýnýfý geçti"; }
        }
    }
}
