    using System;
    using System.Collections.Generic;
    using System.IO;

    namespace _11_08
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
            /// Se dă un şir cu n elemente, numere reale, numerotate de la 1 la n.
            /// Determinaţi numărul de ordine al primei şi al ultimei apariţii a valorii maxime din şir.
            /// </summary>
            private static void P3()
            {
                StreamReader sr = new StreamReader("pozmax.in");
                int n;
                n=int.Parse(sr.ReadLine());

                List<double> numere = new List<double>();
                string lines = sr.ReadToEnd();
                char[] seps = { ' ', '\t', '\n', '\r' };

                string[] tokens = lines.Split(seps, StringSplitOptions.RemoveEmptyEntries);

                for(int i=0; i<tokens.Length; i++)
                {
                    numere.Add(double.Parse(tokens[i]));
                }
                sr.Close();

                double maxim = numere[0];
                int p=0, u=0;

                for(int i=1; i<numere.Count; i++)
                {
                    if (numere[i] > maxim)
                    {
                        maxim = numere[i];
                        p = u = i;
                    }
                    else if (numere[i] == maxim)
                        u = i; 
                }

                StreamWriter sw = new StreamWriter("pozmax.out");
                sw.WriteLine("{0} {1}",p+1,u+1);
                sw.Close();
            }

        /// <summary>
        /// Într-un şir de numere naturale se numeşte vârf un element care are doi vecini şi este strict mai mare decât aceştia.
        /// Se dă un şir cu n elemente, numere naturale.
        /// Calculaţi suma elementelor din şir care sunt vârfuri.
        /// </summary>
        private static void P2()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            string line;
            line = Console.ReadLine();
            string[] tokens = line.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            int[] numere=new int[n];
            int result = 0;

            for(int i=0;i<tokens.Length;i++)
            {
                numere[i] = int.Parse(tokens[i]);
            }
            for(int i=1; i<n-1; i++)
            {
                if (numere[i] > numere[i - 1] && numere[i] > numere[i + 1])
                    result+=numere[i];
            }
            Console.WriteLine(result);
        }

        /// <summary>
        /// Se dau n numere naturale. Determinaţi câte cifre pare şi câte cifre impare se află în total în cele n numere.
        /// </summary>
        private static void P1()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            string line;
            line = Console.ReadLine();
            string[] tokens = line.Split(' ');

            int nr;
            int pareTotal = 0, impareTotal = 0;
            int pareCurent=0, impareCurent=0;

            for(int i=0; i<tokens.Length; i++)
            {
                nr = int.Parse(tokens[i]);
                (pareCurent, impareCurent) = ParImpar(nr);
                pareTotal += pareCurent;
                impareTotal += impareCurent;
            }
            Console.WriteLine($"{pareTotal} {impareTotal}");
        }

        private static (int, int) ParImpar(int nr)
        {
            int cifra;
            int par = 0, impar = 0;
            while(nr>0)
            {
                cifra = nr % 10;
                nr /= 10;
                if (cifra % 2 == 0)
                    par++;
                else
                    impar++;
            }
            return (par, impar);
        }
    }
}
