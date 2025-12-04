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

        private void button1_Click(object sender, EventArgs e)
        {
            kisi insan=new kisi();
            MessageBox.Show("Ad=" + insan.Ad +
                "soyad=" + insan.Soyad + "boy=" + insan.Boy +
                "kilo=" + insan.Kilo + "yas=" + insan.Yas);
        }
    }
}
