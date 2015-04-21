using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Multiverse
{
    class Program
    {
        static int ConvertDigits(string digit)
        {
            int number = -1;
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

        static ulong Power(int pow)
        {
            ulong result = 1;
            int number = 13;
            for (int i = 0; i < pow; i++)
            {
                result *= (ulong)number;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string inputMessage = Console.ReadLine();

            ulong result = 0;

            for (int i = 0; i < inputMessage.Length; i += 3)
            {
                string digit = inputMessage.Substring(i, 3);
                int digitOfMultiverseSystem = ConvertDigits(digit); // 1,....15 chisloto

                result += (ulong)digitOfMultiverseSystem * Power(inputMessage.Length / 3 - 1 - i / 3);
            }

            Console.WriteLine(result);
        }
    }
}
