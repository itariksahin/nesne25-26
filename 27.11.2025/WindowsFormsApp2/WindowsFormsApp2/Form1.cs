using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yazdırma yaz = new yazdırma();
            yaz.yazdir(numara:textBox4.Text,ad:textBox1.Text,
                sinif:textBox3.Text,soyad:textBox2.Text);
        }
    }
}
