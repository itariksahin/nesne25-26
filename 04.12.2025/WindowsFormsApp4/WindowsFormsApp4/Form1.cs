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
            otomobil araba=new otomobil();
            MessageBox.Show("Marka=" + araba.Marka + "Renk=" + araba.Renk);
            MessageBox.Show("Program bitti");
        }
    }
}
