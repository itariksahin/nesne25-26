using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class yaz
    {
        public void yazdir(params string[] ad)
        {
            foreach (string s in ad)
            {
                MessageBox.Show(s);
            }
        }
    }
}
