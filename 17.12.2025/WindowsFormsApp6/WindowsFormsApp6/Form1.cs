using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sekil s=new Sekil(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            s.Bilgiyazdir();
            Daire d = new Daire(Convert.ToDouble(textBox1.Text));
            d.Bilgiyazdir();
        }
    }
}
