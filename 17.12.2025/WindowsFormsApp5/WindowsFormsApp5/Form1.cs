using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            egitim yeni_ogrenci= new egitim();
            yeni_ogrenci.Ad = textBox1.Text;
            yeni_ogrenci.Soyad= textBox2.Text;
            yeni_ogrenci.Universite= textBox3.Text;
            yeni_ogrenci.Bolum = textBox4.Text;
            yeni_ogrenci.yazdir();
            ogrenci yeni_ogrenci2 = new ogrenci();
            yeni_ogrenci2.Ad = textBox1.Text;
            yeni_ogrenci2.Soyad = textBox2.Text;
            yeni_ogrenci2.yazdir();
        }
    }
}
