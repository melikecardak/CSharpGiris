using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string ogrenci1 = "Çağıl Alsaç";
            string ogrenci2 = "Leo Alsaç";
            string ogrenci3 = "Angel Alsaç";

            string[] ogrenciler = new string[3]; //initialization
            ogrenciler[0] = "Çağıl Alsaç";
            ogrenciler[1] = "Leo Alsaç";
            ogrenciler[2] = "Angel Alsaç";

            Console.WriteLine(ogrenciler[0]); //Çağıl Alsaç

            string adSoyad; //declaration
            adSoyad = "Muhittin Can"; //assign, set

            int[] numbers = new[] //new[3] , {1, 2, 3}
            {
                1,
                2,
                3
            };

            decimal[] decimals = new decimal[5] { 1.1m, 2.2m, 3.3m, 4.4m, 5.5m };

            char[] karakterler = { 'C', 'a', 'n' };
            Console.WriteLine(""+ karakterler[0]+ karakterler[1]+ karakterler[2]);
            string ad = "Can";
            Console.WriteLine(ad);

            foreach (string ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }



            Console.ReadLine();

        }
    }
}
