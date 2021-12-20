using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            P3();
        }

        /// <summary>
        /// Sa se scrie o functie care citeste un sir de n nr nat si determina nr din sir care are prima cifra minima
        /// Daca exista mai multe nr cu prima cifra minima, se va det cel mai mare dintre acestea
        /// </summary>
        
        ///<example>
        /// daca n=5
        /// si nr sunt: 72 30 12 165 725
        /// atunci se va afisa 165
        ///</example>
        private static void P3()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int numar;
            int primaCifra;
            int cifraMinima=10;
            int rezultat=0;

            for(int i=0; i<n; i++)
            {
                numar = int.Parse(Console.ReadLine());
                primaCifra = PrimaCifra(numar);
                if (primaCifra < cifraMinima)
                {
                    cifraMinima = primaCifra;
                    rezultat = numar;
                }
                else if(primaCifra == cifraMinima)
                {
                    if (numar > rezultat)
                        rezultat = numar;
                }
            }
            Console.WriteLine($"Rezultatul este {rezultat}");
            Console.WriteLine();    
        }

        private static int PrimaCifra(int numar)
        {
            while (numar > 9)
                numar /= 10;
            return numar;
        }

        /// <summary>
        /// Sa se scrie o functie care citeste nr nat n si determina suma S=1*n + 2*(n-1) + 3*(n-2)+...+ n*1
        /// </summary>

        /// <example>
        /// Daca n=3 atunci suma = 10
        /// </example>
        private static void P2()
        {
            int n, suma = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for(int i=1, j=n ; i<=n ; i++, j--)
            {
                suma = suma + i * j;
            }
            Console.WriteLine($"Suma 1*n + 2*(n-1)+ 3*(n-2)+...+ n*1 este {suma}");
            Console.WriteLine();
        }

        /// <summary>
        /// Sa se scrie o functie care citeste nr nat n si determina suma S=1*2+2*3+...+n*(n+1) 
        /// </summary>

        /// <example>
        /// daca n=3 atunci S=20
        /// </example>example>

        private static void P1()
        {
            int n, S = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                S = S + i * (i + 1);
            Console.WriteLine($"Suma 1*2+2*3+...+{n}*{n+1} este {S}");
            Console.WriteLine();
        }
    }
}
