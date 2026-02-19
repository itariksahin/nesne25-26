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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Miskin hayvan kayıt formu";
            this.BackColor = Color.DarkRed;
            this.ForeColor = Color.DarkCyan;
            Random rnd = new Random();
            int en = rnd.Next(500, 900);
            int boy = rnd.Next(700, 1200);
            this.Size = new Size(en, boy);
            label1.Text = "Ecrin bunu tıklma";
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            int x_konumu = rnd.Next(150, 500);
            int y_konumu = rnd.Next(150, 500);
            label1.Location = new Point(x_konumu, y_konumu);
            label1.Size = new Size(x_konumu / 2, y_konumu / 2);
            textBox1.Location= new Point(x_konumu-50, y_konumu-50);
            textBox1.Size=new Size(en/10, boy/10);
            button1.Text = "TIKLA BENİ";
            button1.BackColor = Color.Purple;
            button1.ForeColor = Color.ForestGreen;
            button1.Location=new Point(x_konumu - 90, y_konumu - 90);
            button1.Size = new Size(en / 10, boy / 20);

        }
    }
}
