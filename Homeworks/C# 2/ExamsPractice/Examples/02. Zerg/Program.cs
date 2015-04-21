using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Zerg
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new List<string> { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };

            var input = Console.ReadLine();

            long reprsentation = 0;

            for (int i = 0; i < input.Length; i += 4)
            {
                var digit = input.Substring(i, 4);
                var decimalValue = alphabet.IndexOf(digit);

                reprsentation *= 15;
                reprsentation += decimalValue;
            }
            Console.WriteLine(reprsentation);
        }
    }
}
