using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLUTTON___Obżartuchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string text = Console.ReadLine();
                string[] tab_text = text.Split(' ');
                int u = int.Parse(tab_text[0]);
                int p = int.Parse(tab_text[1]);

                const int total_time = 24 * 60 * 60;
                double suma = 0;
                for (int j = 0; j < u; j++)
                {
                    int tmp = int.Parse(Console.ReadLine());
                    suma += total_time / tmp;
                }
                Console.WriteLine(Math.Ceiling(suma / p));
            }
        }
    }
}
