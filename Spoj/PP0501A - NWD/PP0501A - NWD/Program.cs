using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0501A___NWD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string tekst = Console.ReadLine();
                string[] liczby = tekst.Split(' ');
                int a = int.Parse(liczby[0]);
                int b = int.Parse(liczby[1]);

                Console.WriteLine(NWD(a, b));
            }
        }

        static int NWD(int a, int b)
        {
            while(b != 0)
            {
                int c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
    }
}
