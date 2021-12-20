using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int st=1234567890, dr=1568123456;
            int mij;
            mij=(st+dr)/2;
            mij = st + (dr - st) / 2;
            Console.WriteLine($"Mijlocul intervalului [{st}.{dr}] este {mij}");
        }
    }
}
