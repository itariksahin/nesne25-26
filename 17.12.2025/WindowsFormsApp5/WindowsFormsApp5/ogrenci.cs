using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public class ogrenci
    { public string Ad {  get; set; }
      public string Soyad {  get; set; }
        
      public string Anne_adi {  get; set; }
      public string Baba_adi {  get; set; }
      public string Yas {  get; set; }
      public string Milliyet { get; set; }
        
        public void yazdir()
        {
            MessageBox.Show(Ad + Soyad);
        }

    }
}
