using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _12_13
{
    enum MyEnum
    {
        Val1 = 1,
        Val2 = 4,
        Val3 = 8
    }
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            P2();
        }

        /// <summary>
        /// Un număr natural în baza 10 se numește prețios dacă numărul de cifre ale sale din baza 2 este număr prim.
        /// Se dă un interval [a,b].Determinați câte numere prețioase se află în acest interval.
        /// </summary>
        private static void P2()
        {
            ulong a, b;
            string line = Console.ReadLine();
            string[] tokens = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            a = ulong.Parse(tokens[0]);
            b = ulong.Parse(tokens[1]);

            if (a > b)
            {
                Swap(ref a, ref b);
            }
            int cifreb2;
            ulong x = 0;
            for (ulong nr = a; nr <= b; nr++)
            {
                cifreb2 = Cifreb2(nr);
                if (IsPrime(cifreb2))
                {
                    x++;
                }
            }
            Console.WriteLine(x);
        }

        private static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n % 2 == 0 && n != 2)
                return false;
            for (int d = 3; d * d <= n; d = d + 2)
                if (n % d == 0)
                    return false;
            return true;
        }

        private static int Cifreb2(ulong nr)
        {
            int result = 0;
            while (nr != 0)
            {
                result++;
                nr /= 2;
            }
            return result;
        }

        private static void Swap(ref ulong a, ref ulong b)
        {
            ulong aux;
            aux = a;
            a = b;
            b = aux;
        }

        /// <summary>
        /// Se dă un număr n scris în baza b și trebuie afișat în baza c.
        /// </summary>
        private static void P1()
        {
            int n, b, c;
            string line = Console.ReadLine();
            string[] tokens = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                n = int.Parse(tokens[0]);
                b = int.Parse(tokens[1]);
                c = int.Parse(tokens[2]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            int n10 = Convert_to_10(n, b);
            //Debug.WriteLine(n10);

            // int nc = Convert_to_Base(n10,c);
            //Console.WriteLine(nc);

            Console.WriteLine(Convert_to_Base_Reloaded(n10, c));
        }

        private static string Convert_to_Base_Reloaded(int n10, int c)
        {
            string result = "";
            int cifra;

            while (n10 != 0)
            {
                cifra = n10 % c;
                n10 = n10 / c;
                result = cifra.ToString() + result;
            }
            return result;
        }

        /// <summary>
        /// Converteste un nr din baza 10 in baza c
        /// </summary>
        /// <param name="n10">Nr in baza 10</param>
        /// <param name="c">Baza tinta</param>
        /// <returns></returns>
        private static int Convert_to_Base(int n10, int c)
        {
            // 135 :7 = 19 rest 2
            // 19 : 7 = 2 rest 5
            // 2 : 7 = 0 rest 2

            int p = 1; ;
            int result = 0;
            int cifra;

            while (n10 != 0)
            {
                cifra = n10 % c;
                n10 = n10 / c;
                result = result + cifra * p;
                p = p * 10;
            }
            return result;
        }

        /// <summary>
        /// Converteste un nr din baza b in baza 10
        /// </summary>
        /// <param name="n"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int Convert_to_10(int n, int b)
        {
            // 2013=3 + 1*4 + 0*4^2 + 2*4^3

            int c;
            int result = 0;
            int p = 1;

            while (n != 0)
            {
                c = n % 10;
                n /= 10;
                result += c * p;
                p *= b;
            }
            return result;
        }
    }
}
