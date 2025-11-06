using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { int toplam = 0;
            try
            {
                toplam = Convert.ToInt16(textBox1.Text) + Convert.ToInt16(textBox2.Text);
                MessageBox.Show(toplam.ToString());
            }
            catch {
                MessageBox.Show("yanlış deger girdiniz");
            }
            finally
            {
                MessageBox.Show("Bizi tercih ettiğini için teşekkür ederiz");

            }
        }
    }
}
