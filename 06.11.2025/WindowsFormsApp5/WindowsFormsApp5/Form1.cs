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
            int say=Convert.ToInt32(textBox1.Text);
            int birak=Convert.ToInt32(textBox2.Text);
            int topla = 0;
            int sayacac = 0;
            while (sayacac <= say)
            {
                topla = topla + sayacac;
                if (topla > birak) break;
                sayacac++;
            }
            MessageBox.Show("sonuc=" + topla.ToString());
        }
    }
}
