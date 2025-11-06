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
            int dongu_say = 1;
            int toplam =0;
            while(toplam<= Convert.ToUInt16(textBox1.Text))
            {
                toplam = toplam + dongu_say;
                dongu_say++;
            }
            MessageBox.Show("döngü toplam" + dongu_say.ToString() + "kez çalıştı");
        }
    }
}
