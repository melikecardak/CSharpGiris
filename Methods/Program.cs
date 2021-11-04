using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayName();
            DisplayName();
            DisplayName();

            DisplayAdd(1, 2); //Add Result: 3

            int n1 = 5;
            int n2 = 7;
            DisplayAdd(n1, n2);

            int r = Subtract(n2, n1);
            Console.WriteLine("Subtract Result: " + r);

            Console.WriteLine("PI: " + GetPI());

            Console.WriteLine(Multiply(10,100)); //1000

            Console.WriteLine(Multiply(1,2,3)); //6 - method overload

            Console.WriteLine(Multiply(3,4,5,6)); //360

            string adSoyad = AdSoyadGetir("Çağıl", "Alsaç");
            Console.WriteLine("Adınız: {0}", adSoyad); //Sayın Çağıl Alsaç

            adSoyad = AdSoyadGetir("Emre", "Can", "Kaymak", "Bay");
            Console.WriteLine(adSoyad);

            Console.WriteLine($"Toplam:{Topla(1, 2, 3, 4, 5, 10, 20, 30)}");

            Console.ReadLine();
        }

        static void DisplayName() // kodların gruplandırılmasını sağlar. Geriye bir şey dönmez.
        {
            Console.WriteLine("Çağıl Alsaç");
        }

        static void DisplayAdd(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Add Result: " + result);

        }

        static int Subtract(int s1, int s2)
        {
            //int sonuc;
            //sonuc = s1 - s2;
            return s1 - s2;
            // Console.WriteLine("Subtract Result: " + (s1 - s2));
        }

        static double GetPI()
        {
            return 3.14;
        }

        static string Multiply(int sayi1, long sayi2)
        {
            long sonuc = sayi1 * sayi2;
            return "" + sonuc;
        }

        static int Multiply (int sayi1, int sayi2, int sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }

        //multiply(1,2,3,4)
        //multiply(1,2,3) her zaman en sonda tanımlanır. Method overload için kullanılmaması gerekir.
        static int Multiply(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            return sayi1 * sayi2 * sayi3 * sayi4;
        }

        static string AdSoyadGetir(string ad, string soyad, string baslik = "Sayın")
        {
            return baslik + " " + ad + " " + soyad;
        }

        static string AdSoyadGetir(string ad, string ortaAd, string soyad, string baslik)
        {
            string sonuc = $"{baslik}, {ad} {ortaAd} {soyad}";
            return sonuc;
        }

        static int Topla(params int[] sayilar)
        {
            return sayilar.Sum();
        }
    }
}
