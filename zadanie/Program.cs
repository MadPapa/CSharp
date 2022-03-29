using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czy parzysta = " + CzyParzysta(4));
            Console.ReadKey();
        }
        static bool CzyParzysta(int liczba)
        {
            return (liczba & 1) == 0;
        }
    }
}
