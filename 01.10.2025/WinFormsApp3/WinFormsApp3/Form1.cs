namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ders1net;
            double ders2net;
            double ders3net;
            double ders4net;
            double ders5net;
            double ders6net;
            double ders7net;
            double ders8net;
            double toplamnet;
            ders1net = Convert.ToDouble(textBox1.Text) - (Convert.ToDouble(textBox2.Text) / 4);
            textBox3.Text = Convert.ToString(ders1net);
            ders2net = Convert.ToDouble(textBox4.Text) - (Convert.ToDouble(textBox5.Text) / 4);
            textBox6.Text = Convert.ToString(ders2net);
            ders3net = Convert.ToDouble(textBox7.Text) - (Convert.ToDouble(textBox8.Text) / 4);
            textBox9.Text = Convert.ToString(ders3net);
            ders4net = Convert.ToDouble(textBox10.Text) - (Convert.ToDouble(textBox11.Text) / 4);
            textBox12.Text = Convert.ToString(ders4net);
            ders5net = Convert.ToDouble(textBox13.Text) - (Convert.ToDouble(textBox14.Text) / 4);
            textBox15.Text = Convert.ToString(ders5net);
            ders6net = Convert.ToDouble(textBox16.Text) - (Convert.ToDouble(textBox17.Text) / 4);
            textBox18.Text = Convert.ToString(ders6net);
            ders7net = Convert.ToDouble(textBox19.Text) - (Convert.ToDouble(textBox20.Text) / 4);
            textBox21.Text = Convert.ToString(ders7net);
            ders8net = Convert.ToDouble(textBox22.Text) - (Convert.ToDouble(textBox23.Text) / 4);
            textBox24.Text = Convert.ToString(ders8net);
            toplamnet = ders1net + ders2net + ders3net + ders4net + ders5net + ders6net + ders7net + ders8net;
            textBox25.Text= Convert.ToString(toplamnet);

        }
    }
}
