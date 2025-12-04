using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class kisi
    {
        int yas;
        int boy;
        int kilo;
        string ad;
        string soyad;
        public kisi()
        {
            ad = "UMUT";
            soyad = "BULUT";
            yas = 38;
            kilo = 75;
            boy = 188;
        }
        public int Yas
        {
            get
            {
                return yas;
            }
        }
        public int Boy
        {
            get
            {
                return boy;
            }
        }
        public int Kilo
        {
            get
            {
                return kilo;
            }
        }
        public string Ad
        {
            get 
            { 
                return ad; 
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
        }
    }
}
