using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //logical operators: and (&&) or (||) not (!)
            //relational operators: ==, !=, >=, <=, <, >
            //aritmetic operators: +, -, *, /, %
            //assignment operator: =

            var number = 10;
            if (number == 10) //true 
            {
                Console.WriteLine("Number is 10 ");
            }
            else // number != 10
            {
                Console.WriteLine("Number is not 10");
            }

            number = 11;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10"); //ternary operator 

            number = 20;
            if (number == 10)
                Console.WriteLine("On");
            else if (number == 20)
                Console.WriteLine("Yirmi");
            else
                Console.WriteLine("On veya Yirmi değil");

            switch (number)
            {
                case 10: Console.WriteLine("On");
                    break;
                case 20: Console.WriteLine("Yirmi");
                    break;
                default:
                    Console.WriteLine("On veya Yime değil");
                    break;
            }

            int not = 2;
            if (not >= 1 && not <= 2 )
                Console.WriteLine("Kötü");
            else if (not ==3 )
                Console.WriteLine("Orta");
            else
                Console.WriteLine("İyi");


            not = 60;
            if ( not >=90 && not<=100)
                Console.WriteLine("A");
            else if (not >= 80 && not < 90)
                Console.WriteLine("B");
            else if (not >= 70 && not < 80)
                Console.WriteLine("C");
            else if (not >= 60 && not < 70)
                Console.WriteLine("D");
            else if ( not < 60 )
                Console.WriteLine("F");

            Console.ReadLine();


        }
    }
}
