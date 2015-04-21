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
        for (int i = 0; i < input.Length; i += 3)
        {
            string digit = input.Substring(i, 3);

            int digitLikeNumber = ConvertDigit(digit);

            sum += (ulong)digitLikeNumber * (ulong)Math.Pow(13, input.Length / 3 - i / 3 - 1);

        }
        Console.WriteLine(sum);


    }

    private static int ConvertDigit(string digit)
    {
        int number = 0;

        switch (digit)
        {
            case "CHU": number = 0; break;
            case "TEL": number = 1; break;
            case "OFT": number = 2; break;
            case "IVA": number = 3; break;
            case "EMY": number = 4; break;
            case "VNB": number = 5; break;
            case "POQ": number = 6; break;
            case "ERI": number = 7; break;
            case "CAD": number = 8; break;
            case "K-A": number = 9; break;
            case "IIA": number = 10; break;
            case "YLO": number = 11; break;
            case "PLA": number = 12; break;
            default: break;
        }

        return number;
    }


}
