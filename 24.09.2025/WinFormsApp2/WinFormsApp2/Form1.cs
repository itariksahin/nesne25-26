using Microsoft.VisualBasic.Devices;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("1 �zerindesiniz");
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("2 �zerindesiniz");
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("3 �zerindesiniz");
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("4 �zerindesiniz");
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }
    }
}
