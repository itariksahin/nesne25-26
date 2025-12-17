using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2=Convert.ToInt32(textBox2.Text);
            label3.Text = "sayı 1=" + sayi1.ToString() + "sayı 2=" + sayi2.ToString();
            SayiTutucu sayi_1= new SayiTutucu();
            sayi_1.ecrin= Convert.ToInt32(textBox1.Text);
            SayiTutucu sayi_2 = sayi_1;
            sayi_2.ecrin= Convert.ToInt32(textBox2.Text);
            label4.Text = "sayı 1=" + sayi_1.ecrin.ToString() + "sayı 2=" + sayi_2.ecrin.ToString();

        }
    }
}
