using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sise
{
    class Program
    {
        public static int Menu()
        {
            int secim = 0;
            Console.Clear();
            Console.WriteLine("1-Su Şişesi Ekle");
            Console.WriteLine("2-Soda Şişesi Ekle");
            Console.WriteLine("3-Su Şişesi Sayısı");
            Console.WriteLine("4-Soda Şişesi Sayısı");
            Console.WriteLine("5-Şise Listesi");
            Console.WriteLine("6-Çıkış");
            Console.Write("Seçim:");
            secim = int.Parse(Console.ReadLine());
            return secim;
        }
        static void Main(string[] args)
        {
            Sise[] siseler = new Sise[100];
            int sayac = 0;
            int secim = 0;
            do
            {
                secim = Menu();
                Console.Clear();
                switch(secim)
                {
                    case 6:break;
                    case 1:
                        {
                            string t, r, m;
                            int u, p;
                            Console.Write("Türü:");
                            t = Console.ReadLine();
                            Console.Write("Rengi:");
                            r = Console.ReadLine();
                            Console.Write("Malsemesi:");
                            m = Console.ReadLine();
                            Console.Write("Uzunluk:");
                            u = int.Parse(Console.ReadLine());
                            Console.Write("Ph değeri:");
                            p = int.Parse(Console.ReadLine());
                            siseler[sayac++] = new SuSisesi(t, r, m, u, p);
                            break; 
                        }
                    case 2:
                        {
                            string t, r, m,it;
                            int u;
                            Console.Write("Türü:");
                            t = Console.ReadLine();
                            Console.Write("Rengi:");
                            r = Console.ReadLine();
                            Console.Write("Malsemesi:");
                            m = Console.ReadLine();
                            Console.Write("Uzunluk:");
                            u = int.Parse(Console.ReadLine());
                            Console.Write("İçerik değeri:");
                            it = Console.ReadLine();
                            siseler[sayac++] = new SodaSisesi(t, r, m, u, it);
                            break;
                        }
                    case 3:
                        Console.WriteLine("Su şişesi Sayısı:" + SuSisesi.sayi);
                        Console.WriteLine("Devam etmek için Tıklatınıx");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Soda şişesi Sayısı:" + SodaSisesi.sayi);
                        Console.WriteLine("Devam etmek için Tıklatınıx");
                        Console.ReadKey();
                        break;
                    case 5:
                        for(int i=0;i<sayac;i++)
                        {
                            siseler[i].bilgiVer();
                            Console.WriteLine("...................");
                        }
                        Console.WriteLine("Devam etmek için Tıklatınıx");
                        Console.ReadKey();
                        break;
                    default:Console.WriteLine("Hatalı girişl yapdpdp");
                        break;
                }
            } while(secim!=6);



            
        }
    }
}
