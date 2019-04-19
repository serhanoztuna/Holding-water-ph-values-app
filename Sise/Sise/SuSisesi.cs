using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sise
{
    class SuSisesi : Sise
    {
        public static int sayi = 0;
        private int pH;
        public int PH
        {
            set
            {
                if (value < 0) pH = 0;
                else if (value > 14) pH = 14;
                else pH = value;
            }
        }
        public void Sertlik()
        {
            if (pH > 7) Console.WriteLine("Yumuşak içimli Su");
            else Console.WriteLine("Sert İçimli Su");
        }
        public SuSisesi(string t, string r, string m, int u, int p) : base(t, r, m, u)
        {
            pH = p;
            sayi++;
        }
        public override void bilgiVer()
        {
            base.bilgiVer();
            Sertlik();
        }
    }
}
