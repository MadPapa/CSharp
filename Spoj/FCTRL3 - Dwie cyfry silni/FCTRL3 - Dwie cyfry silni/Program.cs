using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCTRL3___Dwie_cyfry_silni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int result = 1;
                int number = int.Parse(Console.ReadLine());

                if(number < 10)
                {
                    for (int j = 2; j <= number; j++)
                    {
                        result *= j;
                    }
                    int jednosci = result % 10;
                    int dziesiatki = (result / 10) % 10;

                    Console.WriteLine(dziesiatki + " " + jednosci);
                }
                else
                    Console.WriteLine("0 0");
            }
        }
    }
}

