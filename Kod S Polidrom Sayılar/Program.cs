using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Polidrom_Sayılar
{
    class Program
    {
        static void Main(string[] args)
        {

            string o = "a";
            int a, k;
            int d = 0;
            Console.WriteLine("bir sayı giriniz=");
            a = int.Parse(Console.ReadLine());
            int t = a;

            while (a != 0)
            {
                a /= 10;
                d++;
            }

            int s = d - 1;
            int y = s;
            int[] ters = new int[d];


            for (int i = 0; i < d; i++)
            {
                k = t / ((int)(Math.Pow(10, s)));
                ters[s] = k;
                t = t % (int)(Math.Pow(10, s));

                s--;

            }


            for (int i = 0; i < d; i++)
            {

                Console.Write(ters[i]);

            }


            for (int i = 0; i <= y; i++)
            {
                if (ters[i] == ters[y])

                    o = "polidromdur";

                else
                {
                    o = "polidrom değildir";
                    break;
                }
                y--;
            }
            Console.WriteLine(o);
            int ab = 0;
            for (int i = 0; i <= y; i++)
            {
                ab += ters[i];

            }

            Console.WriteLine(ab);

            Console.ReadKey();
        }
    }
}
