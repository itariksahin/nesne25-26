namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte kilo = Convert.ToByte(textBox2.Text);
            if (kilo < 40) { label3.Text = textBox1.Text + " çok zayýfsýn"; }
            else if(kilo<60) { label3.Text = textBox1.Text + " zayýfsýn"; }
            else if (kilo < 70) { label3.Text = textBox1.Text + " normalsin"; }
            else if (kilo < 90) { label3.Text = textBox1.Text + " Þiþmansýn"; }
            else if (kilo < 110) { label3.Text = textBox1.Text + " obezsin"; }
            else { label3.Text = textBox1.Text + " Tosunsun maþallah"; }
        }
    }
}
