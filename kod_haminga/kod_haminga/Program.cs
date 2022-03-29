using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kod_haminga
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Logo();
            Console.WriteLine("Input:");
            Console.Write("podaj liczbe z zakresu 0 - 255: ");
            int n = int.Parse(Console.ReadLine());
            if(n < 0 || n > 255)
            {
                Console.Clear();
                Logo();
                Console.WriteLine("\nPodana liczba jest spoza zakresu, wprowadz liczbe jeszcze raz");
                Console.WriteLine("Input:");
                Console.Write("podaj liczbe z zakresu 0 - 255: ");
                n = int.Parse(Console.ReadLine());
            }
            int tmp = n;
            int[] m = new int[8];
            int j = 0;
            while (tmp > 0)
            {
                m[j] = tmp % 2;
                tmp /= 2;
                j++;
            }
            Console.WriteLine();
            Console.Write(n + " = ");
            for (int i = m.Length - 1; i >= 0; i--)
            {
                Console.Write(m[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            int c1, c2, c4, c8;
            c1 = (m[0] + m[1] + m[3] + m[4] + m[6]) % 2;
            c2 = (m[0] + m[2] + m[3] + m[5] + m[6]) % 2;
            c4 = (m[1] + m[2] + m[3] + m[7]) % 2;
            c8 = (m[4] + m[5] + m[6] + m[7]) % 2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("C1 = " + c1);
            Console.WriteLine("C2 = " + c2);
            Console.WriteLine("C4 = " + c4);
            Console.WriteLine("C8 = " + c8);
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Output:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{c1}, {c2}, {m[0]}, {c4}, {m[1]}, {m[2]}, {m[3]}, {c8}, {m[4]}, {m[5]}, {m[6]}, {m[7]} = ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write((c1 * 2048) + (c2 * 1024) + (m[0] * 512) + (c4 * 256) + (m[1] * 128) + (m[2] * 64) + (m[3] * 32) + (c8 * 16) + (m[4] * 8) + (m[5] * 4) + (m[6] * 2) + (m[7] * 1));
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }
        public static void Logo()
        {
            Console.WriteLine("###############");
            Console.WriteLine("# KOD HAMINGA #");
            Console.WriteLine("###############");
            Console.WriteLine();
        }
    }
}
