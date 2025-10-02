namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        textBox14.Text=Convert.ToString(
                        Convert.ToDouble(textBox2.Text) *(Convert.ToDouble(textBox3.Text)/100)+
                        Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(textBox5.Text) / 100)+
                        Convert.ToDouble(textBox6.Text) * (Convert.ToDouble(textBox7.Text) / 100)+
                        Convert.ToDouble(textBox8.Text) * (Convert.ToDouble(textBox9.Text) / 100)+
                        Convert.ToDouble(textBox10.Text) * (Convert.ToDouble(textBox11.Text) / 100)+
                        Convert.ToDouble(textBox12.Text) * (Convert.ToDouble(textBox13.Text) / 100)
                        );
        }
    }
}
