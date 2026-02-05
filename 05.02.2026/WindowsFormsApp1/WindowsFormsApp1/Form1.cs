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

        string[] isimler = new string[10];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[index] = textBox1.Text;
            index++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < index; i++)
            {        listBox1.Items.Add(isimler[i]);
        }
        }
    }
}
