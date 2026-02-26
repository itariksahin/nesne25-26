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
            string kullanici_adi = "porselensol";
            string sifre = "helva";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Kullanıcı adı girilmedi");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Şifre girilmedi");
            }
            else
            {   if(kullanici_adi!=textBox1.Text)
                { MessageBox.Show("Kullancı adı hatalı"); }
                if (sifre != textBox2.Text)
                { MessageBox.Show("şifre hatalı"); }
                if(kullanici_adi == textBox1.Text && sifre == textBox2.Text)
                { MessageBox.Show("Giriş başarılı");
                    this.Hide();
                    Form2 form2= new Form2();
                    form2.Show();
                    
                }
                
            }
        }
    }
}
