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

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip yardim=new ToolTip();
            yardim.SetToolTip(textBox1, "Adınızı Küçük harf ile yazınız");
            yardim.SetToolTip(textBox2, "Soyadınızı Büyük harf ile yazınız");
            yardim.SetToolTip(textBox3, "YAşınız sayısal olarak yazınız");
            yardim.SetToolTip(textBox4, "Doğum tarihizi gg/aa/yyyy formatında yazın");
            yardim.SetToolTip(textBox5, "Anne adınızı küçük harfler ile yazınız");
            yardim.SetToolTip(textBox6, "Baba adınızı küçük harfler ile yazınız ");
            yardim.SetToolTip(textBox7, "Adres bilginizi il ilçe içerir şekilde yazınız");
            yardim.SetToolTip(button1, "Kaydetme işlemi yapar");
            yardim.SetToolTip(button2, "İlgili kişiyi siler");
            yardim.SetToolTip(button3, "Değişiklik yapılan bilgileri günceller");
        }
    }
}
