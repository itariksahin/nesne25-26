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
        double[] dizi = new double[75];
        double topla = 0;
        double ort;
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            dizi[index] = Convert.ToDouble(textBox1.Text);
            index++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (double d in dizi)
            { 
            listBox1.Items.Add(d);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<index;i++)
            {
                topla = topla + dizi[i];
            }
            ort = topla / index;
            listBox1.Items.Clear();
            listBox1.Items.Add(ort);
        }
    }
}
