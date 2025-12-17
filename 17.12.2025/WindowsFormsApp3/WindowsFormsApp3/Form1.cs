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
            Matematik mat=new Matematik();
            int a = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Sayı degeri=" + a.ToString());
            mat.Artir(out a);
            MessageBox.Show("Sınıfdan sonra Sayı degeri=" + a.ToString());

        }
    }
}
