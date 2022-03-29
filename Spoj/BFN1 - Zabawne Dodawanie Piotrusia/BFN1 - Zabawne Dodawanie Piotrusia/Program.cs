using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFN1___Zabawne_Dodawanie_Piotrusia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                isPalindrom(Console.ReadLine());
            }
        }

        private static void isPalindrom(string liczba)
        {
            int ile = 0;

            while (true)
            {
                if (liczba.Length == 1)
                {
                    Console.WriteLine(liczba + " 0");
                    break;
                }

                string liczba2 = "";
                
                for (int i = liczba.Length - 1; i >= 0; i--)
                {
                    liczba2 += liczba[i];
                }
                if (liczba == liczba2)
                {
                    Console.WriteLine(liczba + " " + ile);
                    break;
                }
                else
                {
                    liczba = (int.Parse(liczba) + int.Parse(liczba2)).ToString();
                    ile++;
                }
            }   
        }
    }
}
