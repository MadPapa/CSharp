using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0502B___Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string tekst = Console.ReadLine();
                string[] numbers = tekst.Split(' ');
                int n = int.Parse(numbers[0]);
                int tab_size = numbers.Length - 1;
                int[] tab = new int[tab_size];
                int idx = 1;
                for (int j = 0; j < tab_size; j++)
                {
                    tab[j] = int.Parse(numbers[idx]);
                    idx++;
                }
                for (int k = tab_size - 1; k >= 0; k--)
                {
                    Console.Write(tab[k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
