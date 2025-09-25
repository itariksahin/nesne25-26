namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Toplam_fiyat = 0;
        int urun_sayisi;
        private void button1_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10; //Yüzde 10 indirim
            Toplam_fiyat = Toplam_fiyat + indirimliFiyat;
            textBox3.Text = Convert.ToString(Toplam_fiyat);
            urun_sayisi++;
            textBox2.Text = Convert.ToString(urun_sayisi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.20; //Yüzde 20 indirim
            Toplam_fiyat = Toplam_fiyat + indirimliFiyat;
            textBox3.Text = Convert.ToString(Toplam_fiyat);
            urun_sayisi++;
            textBox2.Text = Convert.ToString(urun_sayisi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25; //Yüzde 25 indirim
            Toplam_fiyat = Toplam_fiyat + indirimliFiyat;
            textBox3.Text = Convert.ToString(Toplam_fiyat);
            urun_sayisi++;
            textBox2.Text = Convert.ToString(urun_sayisi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.30; //Yüzde 30 indirim
            Toplam_fiyat = Toplam_fiyat + indirimliFiyat;
            textBox3.Text = Convert.ToString(Toplam_fiyat);
            urun_sayisi++;
            textBox2.Text = Convert.ToString(urun_sayisi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.40; //Yüzde 40 indirim
            Toplam_fiyat = Toplam_fiyat + indirimliFiyat;
            textBox3.Text = Convert.ToString(Toplam_fiyat);
            urun_sayisi++;
            textBox2.Text = Convert.ToString(urun_sayisi);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            urun_sayisi = 0;
            Toplam_fiyat = 0;
            textBox1.Text = textBox2.Text = textBox3.Text = "0";

        }
    }
}
