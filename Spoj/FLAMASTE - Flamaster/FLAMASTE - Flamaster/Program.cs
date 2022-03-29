using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAMASTE___Flamaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string tekst = Console.ReadLine();
                string wynik = "";
                int ile = 1, j = 0;
                while(j < tekst.Length)
                {
                    ile = 1;
                    char aktualnyZnak = tekst[j];
                    j++;
                    for (; j < tekst.Length && tekst[j] == aktualnyZnak; j++)
                    {
                        ile++;
                    }
                    if(ile == 1)
                    {
                        wynik += aktualnyZnak.ToString();
                    }
                    else if(ile == 2)
                    {
                        wynik += aktualnyZnak.ToString();
                        wynik += aktualnyZnak.ToString();

                    }
                    else
                    {
                        wynik += aktualnyZnak.ToString() + ile.ToString();
                    }
                }Console.WriteLine(wynik);
            }
        }
    }
}
