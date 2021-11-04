using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiKarsilastirma1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı 1: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayı 2: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayı 3: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            int enBuyuk = sayi1;

            //if (sayi2 >= sayi1)
            //{
            //    if (sayi2 >= sayi3)
            //    {
            //        enBuyuk = sayi2;
            //    }
            //}

            if ( sayi1 == sayi2 && sayi1 == sayi3 && sayi2 == sayi3)
            {
                Console.WriteLine("Bütün sayılar esit. ");
            }
            else
            {
                if (sayi2 >= sayi1 && sayi2 >= sayi1)
                {
                    enBuyuk = sayi2;
                }

                if (sayi3 >= sayi2 && sayi3 >= sayi2)
                {
                    enBuyuk = sayi3;
                }

                Console.WriteLine("En büyük sayı: " + enBuyuk);
                
            }
            Console.ReadLine();
        }
    }
}
