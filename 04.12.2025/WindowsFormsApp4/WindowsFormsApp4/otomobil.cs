using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class otomobil
    {
        string marka = "";
        string renk = "";
        public otomobil()
        {
            marka = "SÜMEYYE OTO";
            renk = "ECRİN KIRMIZISI";
            MessageBox.Show("YApıcı metod çalıştı");
        }

        public string Marka
        { get { return marka; } }
        public String Renk
        { get { return renk; } }
        ~otomobil()
        {
            MessageBox.Show("YIKICI METOD ÇALIŞTI");
        }
    }
}
