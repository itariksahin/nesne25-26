using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class Sekil
    {
        public const double pi = 3.14;
        protected double x, y;
        public Sekil()
        { }
        public Sekil(double x, double y)
        { 
          this.x = x; 
          this.y=y; 
        }
        public virtual double AlanHesap()
        { return x * y; }
        public virtual void Bilgiyazdir()
        {
            MessageBox.Show(AlanHesap().ToString());
        }
    }
}
