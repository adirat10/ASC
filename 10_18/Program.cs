using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_18
{
    class Program
    {
        static void Main(string[] args)
        {
           // DistanceTo();
            ReverseDigits();
        }

        private static void ReverseDigits()
        {
            Console.WriteLine("Introduceti un numar natural format din maxim 3 cifre:");
            string line;
            int n;
            line = Console.ReadLine();
            bool ret = int.TryParse(line, out n);
            if (ret == false)
            {
                Console.WriteLine("Valoarea introdusa nu poate fi convertita intr-un numar intreg");
                return;
            }
            if(n<0 || n>999)
            {
                Console.WriteLine("Numarul introdus nu respecta cerintele problemei!");
                return;
            }
            if(n<10)
            {
                //Console.WriteLine(n);
                //Console.WriteLine("{0}",n);
                Console.WriteLine($"{n}");
            }
            else
            {
                if(n<100)
                {
                    Console.WriteLine($"{n % 10}{n / 10}");
                }
                else
                {
                    Console.WriteLine($"{n % 10}{(n / 10) % 10}{n / 100}");
                }
            }
        }

        private static void DistanceTo()
        {
            Console.WriteLine("Introduceti km la care va aflati:");
            int km,distanta;
            km = int.Parse(Console.ReadLine());
            if (km > 60)
                distanta = km - 60;
            else
                distanta = 60 - km;
            Console.WriteLine($"Distanta este: {distanta}");

            //Console.WriteLine($"Distanta este: {Math.Abs(km-60)}");
        }
    }
}
