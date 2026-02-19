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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                textBox5.Text = "SENA ŞEFİN YERİ" + "\r\n";
                textBox5.Text += "EV YEMEKLERİ" + "\r\n";
                textBox5.Text += "SİPARİŞ BİLGİ" + "\r\n";
                textBox5.Text += textBox1.Text + "\r\n";
                textBox5.Text += textBox2.Text + "\r\n";
                textBox5.Text += textBox3.Text + "\r\n";
                textBox5.Text += textBox4.Text + "\r\n";
                decimal hesap = 0;
                if (numericUpDown1.Value > 0) 
                {
                    hesap += numericUpDown1.Value * 80;
                    textBox5.Text += string.Format("ÇORBA FİYATI{0:C}", numericUpDown1.Value * 80) + "\r\n";
                }
                if (numericUpDown2.Value > 0)
                {
                    hesap += numericUpDown2.Value * 50;
                    textBox5.Text += string.Format("SALATA FİYATI{0:C}", numericUpDown2.Value * 50) + "\r\n";
                }
                if (numericUpDown3.Value > 0)
                {
                    hesap += numericUpDown3.Value * 270;
                    textBox5.Text += string.Format("KIRMIZI ET FİYATI{0:C}", numericUpDown3.Value * 270) + "\r\n";
                }
                if (numericUpDown4.Value > 0)
                {
                    hesap += numericUpDown4.Value * 170;
                    textBox5.Text += string.Format("BEYAZ ET FİYATI{0:C}", numericUpDown4.Value * 170) + "\r\n";
                }
                if (numericUpDown5.Value > 0)
                {
                    hesap += numericUpDown5.Value * 220;
                    textBox5.Text += string.Format("BALIK FİYATI{0:C}", numericUpDown5.Value * 220) + "\r\n";
                }
                if (numericUpDown6.Value > 0)
                {
                    hesap += numericUpDown6.Value * 80;
                    textBox5.Text += string.Format("SEBZE YEMEĞİ FİYATI{0:C}", numericUpDown6.Value * 80) + "\r\n";
                }
                if (numericUpDown7.Value > 0)
                {
                    hesap += numericUpDown7.Value * 150;
                    textBox5.Text += string.Format("TATLI FİYATI{0:C}", numericUpDown7.Value * 150) + "\r\n";
                }
                if (numericUpDown8.Value > 0)
                {
                    hesap += numericUpDown8.Value * 50;
                    textBox5.Text += string.Format("TATLI FİYATI{0:C}", numericUpDown8.Value * 50) + "\r\n";
                }
                textBox5.Text+="*********************\r\n";
                textBox5.Text += string.Format("TOPLAM {0:C} TL", hesap);


            }
        }

        private void dOSYAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
