using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNO_DOD___Proste_dodawanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                int ile = int.Parse(Console.ReadLine());
                //for (int j = 0; j < ile; j++)
                //{
                    int suma = 0;
                    string tekst = Console.ReadLine();
                    string []liczby = tekst.Split(' ');
                    foreach(string s in liczby)
                        suma += int.Parse(s);
                    
                    Console.WriteLine(suma);
                //}
            }
        }
    }
}
