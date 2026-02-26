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
        ErrorProvider ep=new ErrorProvider();
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int sonuc))
            {
                ep.SetError(textBox1, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(textBox1, "Numara girişi olmadı");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = true;
                ep.SetError(textBox2, "Ad soyad girilmedi");
            }
            else
            {
                ep.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            int dersnotu;
            if(int.TryParse(textBox3.Text,out dersnotu))
            {
                if (dersnotu < 0 || dersnotu > 100)
                {
                    e.Cancel = true;
                    ep.SetError(textBox3, "Not degeri hatalı");
                }
                else
                {
                    ep.SetError(textBox3, "");
                }
            }
            else
            {
                e.Cancel = true;
                ep.SetError(textBox3, "Sayısal değer giriniz");
            }

        }
    }
}
