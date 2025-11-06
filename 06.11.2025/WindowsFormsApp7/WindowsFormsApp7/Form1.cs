using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bankanot = 0;
           double hesap=Convert.ToDouble(textBox1.Text)*Convert.ToDouble(textBox2.Text);
            textBox3.Text = hesap.ToString();
            while(hesap>=200)
            {
                hesap = hesap - 200;
                bankanot++;
            }
            textBox4.Text = bankanot.ToString();
            bankanot = 0;
            while (hesap >= 100)
            {
                hesap = hesap - 100;
                bankanot++;
            }
            textBox5.Text = bankanot.ToString();
            bankanot = 0;
            while (hesap >= 50)
            {
                hesap = hesap - 50;
                bankanot++;
            }
            textBox6.Text = bankanot.ToString();
            bankanot = 0;
            while (hesap >= 20)
            {
                hesap = hesap - 20;
                bankanot++;
            }
            textBox7.Text = bankanot.ToString();
            bankanot = 0;
            while (hesap >=10)
            {
                hesap = hesap - 10;
                bankanot++;
            }
            textBox8.Text = bankanot.ToString();
            bankanot = 0;
        }
    }
}
