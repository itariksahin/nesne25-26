using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public class egitim:ogrenci
    {public string Universite { get;set;}
       public string Bolum {  get;set;}
       public string Mezuniyet_yili {  get;set;}

       public byte Diploma_notu {  get;set;}

       public string Danisman_adi {  get;set;}

        public new void yazdir()
        { MessageBox.Show(Universite + Bolum); }
    }
}
