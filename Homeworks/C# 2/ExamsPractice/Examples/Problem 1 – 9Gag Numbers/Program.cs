using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string digitIn9Gag = string.Empty;
        string numberIn9Gag = string.Empty;
        BigInteger sum = 0;

        foreach (var ch in input)
        {
            digitIn9Gag += ch;
            string digit = ConvertDigit(digitIn9Gag);
            if (digit == "NO")
            {
                continue;
            }

            numberIn9Gag += digit;
            digitIn9Gag = "";
        }

        for (int i = 0; i < numberIn9Gag.Length; i++)
        {
            BigInteger n = BigInteger.Parse(numberIn9Gag[i].ToString());
            int pow = numberIn9Gag.Length - i - 1;
            BigInteger second = Power(pow);
            sum += n * second;
        }

        Console.WriteLine(sum);
    }

    static BigInteger Power(int pow)
    {
        BigInteger number = 1;
        
        for (int i = 0; i < pow; i++)
        {
            number *= 9;
        }

        return number;
    }

    static string ConvertDigit(string digitIn9Gag)
    {
        switch (digitIn9Gag)
        {
            case "-!": return "0"; 
            case "**": return "1"; 
            case "!!!": return "2"; 
            case "&&": return "3"; 
            case "&-": return "4"; 
            case "!-": return "5"; 
            case "*!!!": return "6"; 
            case "&*!": return "7"; 
            case "!!**!-": return "8"; 
            default: return "NO"; 
        }
    }
}