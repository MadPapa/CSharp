using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA05_POT___Czy_umiesz_potęgować
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 0;
            for(int i = 0; i < n; i++)
            {
                string tmp = Console.ReadLine();
                string []temp = tmp.Split(' ');
                first = int.Parse(temp[0]);
                first %= 10;
                second = int.Parse(temp[1]);

                if(second > 0)
                {
                    if (second % 4 == 0)
                        second = 4;
                    else
                        second %= 4;
                    int answer = first;
                    for (int j = 1; j < second; j++)
                    {
                        answer *= first;
                    }
                    Console.WriteLine(answer % 10);
                }
                else
                    Console.WriteLine(1);
            }
        }
    }
}
