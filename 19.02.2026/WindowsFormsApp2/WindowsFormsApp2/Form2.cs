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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("Form Yükleniyor......");
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("Form kapatılıyor");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form tıklandı");
        }
    }
}
