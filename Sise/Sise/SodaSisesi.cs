using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sise
{
    class SodaSisesi:Sise
    {
        public static int sayi = 0;
        public string IcerikTuru { get; set; }
        public SodaSisesi(string t, string r, string m, int u, string it) : base(t, r, m, u)
        {
            IcerikTuru = it;
            sayi++;
        }
        public override void bilgiVer()
        {
            base.bilgiVer();
            Console.WriteLine("İçerik Türü" + IcerikTuru);
        }
    }
}
