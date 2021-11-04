using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesandVariables
{
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe, 
        Cuma,
        Cumartesi,
        Pazar
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region data türleri
            int number1;
            number1 = 3;
            Console.WriteLine("Sayı 1: " + number1); //sayı 1: 3

            number1 = -3;
            Console.WriteLine("Sayı 1: " + number1); //sayı 1: -3

            int number2 = -4;
            Console.WriteLine("Sayı 2: " + number2 + ", Sayı 1: " + number1); //sayı 2: -4, sayı 1: -3

            Console.WriteLine("Sayı 1: {0}, Sayı 2: {1}", number1, number2);

            long n1 = 0; //çok büyük tam sayı değerlerini tutar.

            Console.WriteLine("Number is {0}.", n1); //Number is 0.
            Console.WriteLine("Number is " + n1 + ".");
            Console.WriteLine("int: " + int.MinValue + "..." + int.MaxValue);
            Console.WriteLine("long: " + long.MinValue + "..." + long.MaxValue);

            short s1 = 32000;
            byte b1 = 255;

            bool durum = true;
            durum = false;
            Console.WriteLine(durum);

            char karakter = 'A';
            long number2long = (long)number2; //casting
            Console.WriteLine("Karakter: " + karakter + ", ASCII: " + (int)karakter);

            double duble = 1.23;  //ondalık verileri saklar. floata göre daha fazla veri tutar.
            Console.WriteLine(duble);

            float flut = -567.897F;
            Console.WriteLine(flut);

            decimal ondalik = 123.456M;
            Console.WriteLine(ondalik);

            string gun = "Salı";
            Console.WriteLine(gun);
            Console.WriteLine(Gunler.Salı + " " + (int)Gunler.Salı); //Salı 1

            string characters = "Ankara";
            Console.WriteLine("string is: " + characters);

            char char1 = 'V', char2 = 'a', char3 = 'n';
            Console.WriteLine("Şehir: " + char1 + char2 + char3);

            Console.Write(char1);
            Console.Write(char2);
            Console.Write(char3);
            Console.WriteLine();

            var city = "Ankara";
            Console.WriteLine(city);

            
            #endregion

            #region Escape Sequences (Characters)
            string ad = "\"Çağıl\"";
            Console.WriteLine("Vatandaş: " + ad);

            string dosyaYolu = "C:\\BilgeAdam\\CSharp";
            dosyaYolu = @"C:\\BilgeAdam\\CSharp";

            /* 
                \*: çift tırnak
                \\*: slash
                \n: new line (alt satır)
                \r: carriage return (satır başı)
                \t: tab

            */
            #endregion

            Console.ReadLine();
        }



    }
}
