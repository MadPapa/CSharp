using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRZEDSZK___Przedszkolanka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 0;
            for (int i = 0; i < n; i++)
            {
                string tekst = Console.ReadLine();
                string[] grups = tekst.Split();
                a = int.Parse(grups[0]);
                b = int.Parse(grups[1]);

                if (a > b && a % b == 0)
                {
                    Console.WriteLine(a);
                }
                if (b > a && b % a == 0)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    int wynik = b;
                    while(wynik % a != 0)
                    {
                        wynik += b;
                    }
                    Console.WriteLine(wynik);
                }
            }
            
        }
    }
}
