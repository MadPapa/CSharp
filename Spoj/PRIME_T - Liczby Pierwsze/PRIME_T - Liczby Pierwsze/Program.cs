using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIME_T___Liczby_Pierwsze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(CzyPierwsza(int.Parse(Console.ReadLine())) == true ? "TAK" : "NIE");
            }
        }

        private static bool CzyPierwsza(int v)
        {
            if (v == 1)
                return false;
            for (int i = 2; i < v; i++)
            {
                if (v % i == 0)
                    return false;
            }return true;
        }
    }
}
