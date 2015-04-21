using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        ulong sum = 0;

        for (int i = 0; i < input.Length; i += 4)
        {
            string currentDigit = input.Substring(i, 4);

            int digit = ConvertDigit(currentDigit);

            sum += (ulong)digit * (ulong)(Math.Pow(15, input.Length / 4 - i/ 4 - 1));

        }

        Console.WriteLine(sum);
    }

    private static int ConvertDigit(string currentDigit)
    {
        int digit = 0;

        switch (currentDigit)
        {
            case "Rawr": digit = 0; break;
            case "Rrrr": digit = 1; break;
            case "Hsst": digit = 2; break;
            case "Ssst": digit = 3; break;
            case "Grrr": digit = 4; break;
            case "Rarr": digit = 5; break;
            case "Mrrr": digit = 6; break;
            case "Psst": digit = 7; break;
            case "Uaah": digit = 8; break;
            case "Uaha": digit = 9; break;
            case "Zzzz": digit = 10; break;
            case "Bauu": digit = 11; break;
            case "Djav": digit = 12; break;
            case "Myau": digit = 13; break;
            case "Gruh": digit = 14; break;

            default: break;
        }
        return digit;
    }
}
