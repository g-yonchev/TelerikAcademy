using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StrangeLand_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            // bIN oBJEC pNWE hT
            // 1    2     5    6 

            string filled = string.Empty;
            string numberInSystem = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                filled += message[i];

                string digit = ConvertDigit(filled);

                if (digit != "NO!")
                {
                    numberInSystem += digit;
                    filled = "";
                }
            }

            long sum = 0;

            for (int i = 0; i < numberInSystem.Length; i++)
            {
                sum += (Convert.ToInt64(numberInSystem[i]) - '0') * (long)Math.Pow(7, numberInSystem.Length - 1 - i);
            }

            Console.WriteLine(sum);
        }

        static string ConvertDigit(string digit)
        {
            string result = "NO!";

            switch (digit)
            {
                case "f": result = "0"; break;
                case "bIN": result = "1"; break;
                case "oBJEC": result = "2"; break;
                case "mNTRAVL": result = "3"; break;
                case "lPVKNQ": result = "4"; break;
                case "pNWE": result = "5"; break;
                case "hT": result = "6"; break;

                default: break;
            }
            return result;
        }
    }
}
