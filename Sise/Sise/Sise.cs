using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sise
{
    abstract class Sise
    {
        private string tur;
        public string renk;
        public string malzeme;
        public int uzunluk;
        public string Tur
        {
            get { return tur; }
            set
            {
                if (value == null)
                    Console.WriteLine("Değer Null Olamaz");
                else if(value.Length<3)
                {
                    Console.WriteLine("Değer 3\'ten küçük olamaz");
                    tur = "Yok";
                }
                else if(value.Length>10)
                {
                    Console.WriteLine("Değer 10\'dan büyük olamaz");
                    tur = value.Substring(0, 10);
                }
                else tur = value;
            }
        }
        public Sise(string t,string r,string m,int u)
        {
            Tur = t;
            renk = r;
            malzeme = m;
            uzunluk = u;
        }
        public virtual void bilgiVer()
        {
            Console.WriteLine("Tur:" + Tur);
            Console.WriteLine("Rengi:" + renk);
            Console.WriteLine("Malzemesi:" + malzeme);
            Console.WriteLine("Uzunluğu" + uzunluk);
        }
    }
}
