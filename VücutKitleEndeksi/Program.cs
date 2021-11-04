using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VücutKitleEndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Vüct kitle endeksi
            //< 18 alti < 20 
            //18-25 > Normal 
            //25-30 > kilolu
            //30-35 > obez
            //bunların üstü "else " - McDonals 

            double boy, kilo, endeks = 0;
            Console.Write("Boyunuzu M cinsinden giriniz (Ornegin: 1,55): ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu giriniz: ");
            kilo = Convert.ToDouble(Console.ReadLine());
            endeks = kilo / (boy * boy);
            Console.WriteLine("**********************");
            Console.WriteLine("Vücut Kütle Endeksiniz: {0}", endeks);
          
           if ( endeks < 18 )
            {
                Console.WriteLine("Tebrikler 2 boyutlusunuz, biraz daha protein alalım");
            }
            
           else if (endeks >= 18 && endeks < 25)
            {
                Console.WriteLine("Normal");
            }

           else if ( endeks >= 25 && endeks < 30)
            {
                Console.WriteLine("Kilolu");
            }
           else if (endeks >= 30 && endeks < 35)
            {
                Console.WriteLine("Obez");
            }
           else
            {
                Console.WriteLine("McDonals gibisiniz");
            }

        

          

            Console.ReadLine();
        }

    }
}
