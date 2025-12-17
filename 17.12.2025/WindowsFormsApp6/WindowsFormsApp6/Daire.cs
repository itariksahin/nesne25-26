using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Daire:Sekil
    {
        public Daire(double r):base(r,0)
        { }
        public override double AlanHesap()
        {
            return pi * x * x;
        }
    }
}
