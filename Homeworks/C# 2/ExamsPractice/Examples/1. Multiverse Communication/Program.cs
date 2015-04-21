using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Multiverse_Communication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            long result = 0;

            for (int i = 0; i < input.Length; i += 3)
            {
                string digit = input.Substring(i, 3);

                int digitAsNumber = ConvertDigit(digit);

                result += digitAsNumber * (long)Math.Pow(13, (input.Length / 3) - (i / 3) - 1);
            }

            Console.WriteLine(result);
        }

        static int ConvertDigit(string digit)
        {
            int result = 0;

            switch (digit)
            {
                case "CHU": result = 0; break;
                case "TEL": result = 1; break;
                case "OFT": result = 2; break;
                case "IVA": result = 3; break;
                case "EMY": result = 4; break;
                case "VNB": result = 5; break;
                case "POQ": result = 6; break;
                case "ERI": result = 7; break;
                case "CAD": result = 8; break;
                case "K-A": result = 9; break;
                case "IIA": result = 10; break;
                case "YLO": result = 11; break;
                case "PLA": result = 12; break;
                default: break;
            }

            return result;
        }
    }
}
