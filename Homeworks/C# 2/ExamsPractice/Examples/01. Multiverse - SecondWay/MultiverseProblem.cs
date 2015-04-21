using System;
namespace Multiverse
{
    class MultiverseProblem
    {
        static void Main()
        {
            string input = Console.ReadLine();
            // IVA YLO
            //  1   0
            long sum = 0;
            long digitIn13 = -1;
            for (int i = 0; i < input.Length; i += 3)
            {
                string digit = input.Substring(i, 3);

                switch (digit)
                {
                    case "CHU": digitIn13 = 0; break;
                    case "TEL": digitIn13 = 1; break;
                    case "OFT": digitIn13 = 2; break;
                    case "IVA": digitIn13 = 3; break;
                    case "EMY": digitIn13 = 4; break;
                    case "VNB": digitIn13 = 5; break;
                    case "POQ": digitIn13 = 6; break;
                    case "ERI": digitIn13 = 7; break;
                    case "CAD": digitIn13 = 8; break;
                    case "K-A": digitIn13 = 9; break;
                    case "IIA": digitIn13 = 10; break;
                    case "YLO": digitIn13 = 11; break;
                    case "PLA": digitIn13 = 12; break;
                    default: break;
                }
                int power = input.Length / 3 - i/3 - 1;

                long second = (long)Math.Pow(13, power);
                sum += digitIn13 * second;

            }
            Console.WriteLine(sum);
        }
    }
}
