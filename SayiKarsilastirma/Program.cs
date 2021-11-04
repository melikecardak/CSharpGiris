using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiKarsilastirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayı: ");
            string sayi1str = Console.ReadLine();
            short sayi1 = Convert.ToInt16(sayi1str);

            Console.Write("2.sayı: ");
            short sayi2 = short.Parse(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.WriteLine("Sayı 1 (" + sayi1 + ") daha büyük.");
            }
            
            else if (sayi1 < sayi2) // sayi1 <= sayi2
            {
                Console.WriteLine("Sayi 2 (" + sayi2 + ") daha büyük. ");
            }
            else
            {
                Console.WriteLine("İki sayı eşit. ");
            }
            Console.ReadLine();
        }
    }
}
