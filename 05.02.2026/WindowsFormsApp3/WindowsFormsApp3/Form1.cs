using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[100];
        int[,] notlar = new int[100, 6];
        byte index=0;
        string gecici;
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[index] = textBox1.Text;
            notlar[index, 0] = Convert.ToInt32(textBox2.Text);
            notlar[index, 1] = Convert.ToInt32(textBox3.Text);
            notlar[index, 2] = Convert.ToInt32(textBox4.Text);
            notlar[index, 3] = Convert.ToInt32(textBox5.Text);
            notlar[index, 4] = Convert.ToInt32(textBox6.Text);
            notlar[index, 5] = Convert.ToInt32(textBox7.Text);
            index++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < index; i++)
            {
                listBox1.Items.Add(isimler[i]);
                for (int j = 0; j <= 5; j++)
                {
                    gecici =gecici+Convert.ToString(notlar[i, j]+"-");
                }
                listBox1.Items.Add(gecici);
                gecici = "";
            }
        }
    }
}
