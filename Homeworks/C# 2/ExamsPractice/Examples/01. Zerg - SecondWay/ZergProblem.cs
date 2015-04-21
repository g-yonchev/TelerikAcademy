namespace Zerg
{
    using System;

    class ZergProblem
    {

        static int ConvertZergDigitToInt(string digit)
        {
            switch (digit)
            {
                case "Rawr": return 0; break;
                case "Rrrr": return 1; break;
                case "Hsst": return 2; break;
                case "Ssst": return 3; break;
                case "Grrr": return 4; break;
                case "Rarr": return 5; break;
                case "Mrrr": return 6; break;
                case "Psst": return 7; break;
                case "Uaah": return 8; break;
                case "Uaha": return 9; break;
                case "Zzzz": return 10; break;
                case "Bauu": return 11; break;
                case "Djav": return 12; break;
                case "Myau": return 13; break;
                case "Gruh": return 14; break;
                default: throw new ArgumentException();
            }
        }

        static void Main()
        {
            string zergMessage = Console.ReadLine();

            int position = zergMessage.Length / 4 - 1;
            long sum = 0;
            for (int i = 0; i < zergMessage.Length; i += 4)
            {
                string digit = zergMessage.Substring(i, 4);
                sum += ConvertZergDigitToInt(digit) * (long)Math.Pow(15, position);
                position--;
            }

            Console.WriteLine(sum);
        }
    }
}
