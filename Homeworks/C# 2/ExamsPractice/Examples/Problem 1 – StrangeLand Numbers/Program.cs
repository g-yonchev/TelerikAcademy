using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        string digit = string.Empty;
        ulong sum = 0;

        string number = string.Empty;

        foreach (var ch in text)
        {
            digit += ch;

            string answer = CheckIfIsLetter(digit);
            if (answer == "NO!")
            {
                continue;
            }

            digit = string.Empty;

            number += answer;


        }

        for (int i = 0; i < number.Length; i++)
        {
            sum += (ulong)(number[i] - '0') * (ulong)(Math.Pow(7, number.Length - i - 1));
        }

        Console.WriteLine(sum);

    }

    private static string CheckIfIsLetter(string digit)
    {
        string digitInSystem = string.Empty;
        switch (digit)
        {
            case "f": digitInSystem = "0"; break;
            case "bIN": digitInSystem = "1"; break;
            case "oBJEC": digitInSystem = "2"; break;
            case "mNTRAVL": digitInSystem = "3"; break;
            case "lPVKNQ": digitInSystem = "4"; break;
            case "pNWE": digitInSystem = "5"; break;
            case "hT": digitInSystem = "6"; break;
            default: digitInSystem = "NO!"; break;
        }
        return digitInSystem;
    }
}
