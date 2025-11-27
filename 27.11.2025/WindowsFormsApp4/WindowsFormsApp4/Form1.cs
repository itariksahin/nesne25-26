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
            yaz ekranayaz=new yaz();
            ekranayaz.yazdir(textBox1.Text, textBox2.Text,
                textBox3.Text, textBox4.Text,
                textBox5.Text, textBox6.Text,
                textBox7.Text, textBox8.Text,
                textBox9.Text, textBox10.Text,
                textBox11.Text, textBox12.Text,
                textBox13.Text, textBox14.Text,
                textBox15.Text, textBox16.Text,
                textBox17.Text, textBox18.Text,
                textBox19.Text, textBox20.Text);
        }
    }
}
