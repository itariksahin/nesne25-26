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
            Toplama deger=new Toplama();
            int a=Convert.ToInt32(textBox1.Text);
            int b =Convert.ToInt32(textBox2.Text);
            MessageBox.Show("Tam sayı hesapı=" +
               Convert.ToString(a));
            MessageBox.Show("Kesirli sayı hesapı=" +
                    deger.topla(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            MessageBox.Show("Metinsel olarak toplam=" + deger.topla(textBox1.Text, textBox2.Text));
        }
    }
}
