using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());

        int sum = 0;
        int currentMaxNum = 0;

        while (count > 0)
        {
            currentMaxNum = Math.Max(a, Math.Max(b, c));

            if (currentMaxNum == a && a > 0)
            {
                a--;
                goto here;

            }
            if (currentMaxNum == b && b > 0)
            {
                b--;
                goto here;
            }
            if (currentMaxNum == c && c > 0)
            {
                c--;
                goto here;
            }
        here:
            sum += currentMaxNum;
            count--;
        }
        Console.WriteLine(sum);

    }
}

