using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*
            //1.Başla
            //2.Kullanıcıdan TL cinsinden para girilmesi istenir
            //3.Kullanıcı para girer
            //4.Kullanıcıdan para birimi girilmesi istenir (Dolar: d , Euro: e, Pound: p)
            //5.1 Eğer para birimi dolar ise 
            //5.2 Kullanıcının girdiği parayı tanımlı olan kura böl 
            //5.3 Eğer para birimi euro ise
            //5.4 Kullanıcının girdiği parayı tanımlı olan euro kuruna böl
            //5.5 Eğer para birimi pound ise 
            //5.6 Kullanıcının girdiği parayı tanımlı olan pound kuruna böl
            //5.7 Eğer para birimi dolar, euro ve pound değil ise
            //5.8 Kullanıcıdan doğru tanımlı para birimi girilmesi istenir
            //6. Bitir
            //*/

            #region If Else 
            //double tl, dolar =9.51, euro = 11.06, pound = 13.01, sonuc = -1;
            //string paraBirimi;
            //Console.Write("TL cinsinden para giriniz: ");
            //tl = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Para birimi giriniz (Dolar: d, Euro: e, Pound: p): ");
            //paraBirimi = Console.ReadLine();

            ////if (paraBirimi != "d" && paraBirimi != "e" && paraBirimi != "p")
            //if (!(paraBirimi == "d" || paraBirimi == "e" || paraBirimi == "p"))
            //{
            //    Console.WriteLine("Dolar için d, euro için e veya pound için p girilmediğinden işleminiz yapılamadı!");

            //}
            //else  //paraBirimi == "d" || paraBirimi == "e" || paraBirimi == "p"
            //{
            //    if (paraBirimi == "d")
            //    {
            //       sonuc = tl / dolar ;
            //    }
            //    else if (paraBirimi == "e")
            //    {
            //       sonuc = tl / euro;
            //    }
            //    else // paraBirimi == "p"
            //    {
            //        sonuc = tl / pound;
            //    }

            //}

            //if (sonuc != -1)

            //Console.WriteLine("Sonuç: " + sonuc);
            //Console.ReadLine();

            #endregion

            #region Switch 

            double tl;
            double dolar = 9.51;
            double euro = 11.06;
            double pound = 13.01;
            double sonuc = -1;
            string paraBirimi;

            Console.Write("TL cinsinden para giriniz: ");
            tl = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Para birimi giriniz (Dolar: d, Euro: e, Pound: p): ");
            paraBirimi = Console.ReadLine();

            switch (paraBirimi)
            {
                case "d": sonuc= tl / dolar;
                    break;
                case "e": sonuc = tl / euro;
                    break;
                case "p": sonuc = tl / pound;
                    break;
                default: sonuc = -1;
                    break;
            }

            if (sonuc == -1)
                Console.WriteLine("Dolar için d, euro için e veya pound için p girilmediğinden işleminiz yapılamadı!");
            else
                Console.WriteLine("Sonuç: " + sonuc);

            Console.ReadLine();

            #endregion



        }



    }
}
