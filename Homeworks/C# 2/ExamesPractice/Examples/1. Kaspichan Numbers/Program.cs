using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Kaspichan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.WriteLine("A");
            }
            else
            {
                var numeralSystem = new List<string>();

                char letter = 'A';
                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add(Convert.ToString(letter));
                    letter++;
                }

                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add("a" + numeralSystem[i]);
                }

                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add("b" + numeralSystem[i]);
                }

                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add("c" + numeralSystem[i]);
                }

                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add("d" + numeralSystem[i]);
                }

                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add("e" + numeralSystem[i]);
                }

                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add("f" + numeralSystem[i]);
                }

                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add("g" + numeralSystem[i]);
                }

                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add("h" + numeralSystem[i]);
                }

                for (int i = 0; i < 26; i++)
                {
                    numeralSystem.Add("i" + numeralSystem[i]);
                }

                string result = string.Empty;

                while (input > 0)
                {
                    int digit = (int)(input % 256);

                    result = numeralSystem[digit] + result;

                    input /= 256;
                }
                Console.WriteLine(result);
            }
        }
    }
}
