using System;

namespace ConditionallsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin:");
            string giris = Console.ReadLine();

            //Int32 sayi = Convert.ToInt32(giris);
            int sayi = Convert.ToInt32(giris);

            //long longSayi1;
            //Int64 longSayi2;

            //short shortSayi1;
            //Int16 shortSayi2;

            if (sayi > 0) 
                Console.WriteLine("Pozitif sayı");
            else if (sayi > 0) 
                Console.WriteLine("Negatif sayı");
            else 
                Console.WriteLine("Sıfırdır");





            


        }
    }
}
