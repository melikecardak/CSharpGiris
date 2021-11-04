using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EhliyetAlabilme
{
    class Program
    {
        static void Main(string[] args)
        {
            byte yas;
            string egitim, ad, soyad; 
            Console.WriteLine("*** EhliyetApp ***");

            Console.Write("Ad: ");
            ad = Console.ReadLine();

            Console.Write("Soyad: ");
            soyad = Console.ReadLine();

            Console.Write("Yaş: ");
            yas = Convert.ToByte(Console.ReadLine());

            Console.Write("Egitim:  (i: İlkokul veya altı, o: Ortaokul, l: Lise, ü: Üniversite veya üstü) ");
            egitim = Console.ReadLine();

            if (yas >= 18 && (egitim == "l" || egitim == "ü"))
                Console.WriteLine("Sayın " + ad + " " + soyad + ", ehliyet alabilirsiniz.");

            else // yas <18 || (egitim != "l" && egitim != "ü") = yas < 18 || !(egitim == "l" || egitim == "ü")
                Console.WriteLine("Sayın: " + ad + " " + soyad + ", ehliyet alamazsınız. ");

            Console.ReadLine();
        }
    }
}
