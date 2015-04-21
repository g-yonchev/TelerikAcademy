using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevenland_Numbers___formulka
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());

            if (K <= 5)
            {
                K++;
                Console.WriteLine(K);
                K--;
            }
            if (K == 6)
            {
                Console.WriteLine("10");
            }
            if (K >= 10 && K <= 65)
            {
                if (K % 10 == 6)
                {
                    K /= 10;
                    K++;
                    K *= 10;
                    Console.WriteLine(K);
                }
                else
                {
                    K++;
                    Console.WriteLine(K);
                    K--;
                }
            }
            if (K == 66)
            {
                Console.WriteLine("100");
            }
            if (K >= 100 && K <= 665)
            {
                if (K % 100 == 66)
                {
                    K /= 100;
                    K++;
                    K *= 100;
                    Console.WriteLine(K);
                }
                else
                {
                    if (K % 10 == 6)
                    {
                        K /= 10;
                        K++;
                        K *= 10;
                        Console.WriteLine(K);
                    }
                    else
                    {
                        K++;
                        Console.WriteLine(K);
                        K--;
                    }
                }
            }
            if (K == 666)
            {
                Console.WriteLine("1000");
            }
        }
    }
}
