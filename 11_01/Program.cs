using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01
{
    class Program
    {
        // minime si maxime
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            P4();
        }

        /// <summary>
        /// Se dau n numere naturale. Determinaţi cele mai mici trei numere dintre cele date
        /// n>=3
        /// </summary>
        /// <example>
        /// n=5, 1017, 48, 310, 5710, 162  => 310,162,48
        /// </example>
        private static void P4()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            if (n < 3)
                Console.WriteLine("Numarul introdus este prea mic");

            int minim1,minim2,minim3;
            minim1 = minim2 = minim3 = int.MaxValue;

            for(int i=0;i<n;i++)
            {
                int numar;
                numar = int.Parse(Console.ReadLine());
                if (numar <= minim1)
                {
                    minim3 = minim2;
                    minim2 = minim1;
                    minim1 = numar;
                }
                else if (numar <= minim2)
                {
                    minim3 = minim2;
                    minim2 = numar;
                }
                else if (numar < minim3)
                {
                    minim3 = numar;
                }
            }
            Console.WriteLine($"Cele mai mici 3 numere sunt:{minim3},{minim2},{minim1}");
        }

        /// <summary>
        /// Sa se scrie un program care citeste un sir de n numere naturale si determina valoarea maxima din sir si de cate ori apare
        /// </summary>
        /// <example>
        /// 1,3,5,4,5 => valparea maxima este 5, iar numarul de aparitii este 2
        /// </example>
        private static void P3()
        {
            int n;
            int numar;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, cate unul pe o linie");

            int maxim = int.MinValue;
            int aparitii = 0;

            for(int i=0;i<n;i++)
            {
                numar = int.Parse(Console.ReadLine());
                if (numar > maxim)
                {
                    maxim = numar;
                    aparitii = 1;
                }
                else if (numar == maxim) aparitii++;
            }
            Console.WriteLine($"Maximul numerelor este {maxim} si apare de {aparitii} ori");
        }

        /// <summary>
        /// Se citesc numere de la tastatura pana la aparitia lui 0. Sa se determine maximul lor. 
        /// </summary>
        /// <example>
        /// 3,4,5,-1,0 => 5
        /// -1,-2,-3,0 => -1
        /// 0 => empty list
        /// </example>

        private static void P2()
        {
            int numar;
            int maxim = int.MinValue;
            bool result;

            result = int.TryParse(Console.ReadLine(), out numar);
            if (result == false)
            {
                Console.WriteLine("Ceea ce ati introdus nu se poate converti in numar intreg");
                //return;

            }
            if (result==true && numar == 0)
            {
                Console.WriteLine("<Empty list>");
                return;
            }
            while(result ==false || numar!=0)
            {
                if (numar > maxim)
                    maxim = numar;
                result = int.TryParse(Console.ReadLine(), out numar);
                if (result == false)
                {
                    Console.WriteLine("Ceea ce ati introdus nu se poate converti in numar intreg");
                    //return;
                }
            }
            Console.WriteLine($"Cel mai mare numar introdus este: {maxim}");
        }

        /// <summary>
        /// Se dau n numere intregi. Calculati cel mai mare dintre cele n numere date.
        /// </summary>
        private static void P1()
        {
            int n;
            bool result;

            Console.Write("n = ");
            result = int.TryParse(Console.ReadLine(), out n);
            if(result==false)
            {
                Console.WriteLine("Ceea ce ati introdus nu se poate converti in numar intreg");
                return;
            }

            int numar;
            int maxim = int.MinValue;

            for(int i=0; i<n; i++)
            {
                result = int.TryParse(Console.ReadLine(), out numar);
                if (result == false)
                {
                    Console.WriteLine("Ceea ce ati introdus nu se poate converti in numar intreg");
                    return;
                }
                if (numar > maxim)
                    maxim = numar;
            }
            Console.WriteLine($"Cel mai mare numar introdus este: {maxim}");
        }
    }
}
