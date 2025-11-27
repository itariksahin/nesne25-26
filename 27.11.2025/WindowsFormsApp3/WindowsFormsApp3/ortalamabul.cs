using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class ortalamabul
    {
        public int topla(params int[] Sayilar)
        {
            int toplam = 0;
            foreach (var s in Sayilar)
            {
                toplam += s;
            }
            return toplam;

        }

    }
}
