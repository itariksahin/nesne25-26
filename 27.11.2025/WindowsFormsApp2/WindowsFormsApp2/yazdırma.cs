using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class yazdırma
    {
        public void yazdir(string ad, string soyad, string numara,string sinif)
        {
            MessageBox.Show(ad + " " + soyad + " " + numara + " " + sinif);
        }
    }
}
