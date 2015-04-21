using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.They_are_Green
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var letters = new char[n];

            for (int i = 0; i < n; i++)
            {
                letters[i] = Convert.ToChar(Console.ReadLine());
            }

            Factorial(n);

        }

        static void Factorial(int n)
        {
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            if (n == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
