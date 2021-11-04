using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize1, vize2, final, ortalama ;
            const double vizeCarpan = 0.2;
            const double finalCarpan = 0.6;
            string adSoyad;

            Console.Write("Ad Soyad: ");
            adSoyad = Console.ReadLine();

            Console.WriteLine("Vize1 notunu giriniz: ");
            vize1 = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Vize2 notunu giriniz: ");
            vize2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Final notunuz giriniz: ");
            final = Convert.ToDouble(Console.ReadLine());

            ortalama = vizeCarpan * (vize1 + vize2) + finalCarpan * final;

            Console.Write("Ortalama: " + ortalama );

            if (ortalama >= 60 )
            {
                Console.WriteLine(adSoyad + "geçtiniz. " + ortalama );
            }

            else
                Console.WriteLine("Kaldı: ");
            Console.ReadLine();

            


        }
    }
}
