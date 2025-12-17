using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dersler yeni_ogrenci=new Dersler();
            yeni_ogrenci.Ad = textBox1.Text;
            yeni_ogrenci.Soyad=textBox2.Text;
            yeni_ogrenci.Yas=textBox3.Text;
            yeni_ogrenci.Okul_no=textBox4.Text;
            yeni_ogrenci.Sinif=textBox5.Text;
            yeni_ogrenci.Alan=textBox6.Text;
            MessageBox.Show(yeni_ogrenci.Ad + yeni_ogrenci.Soyad + yeni_ogrenci.Yas);
        }
    }
}
