using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Durankulak_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> list = new Dictionary<string, int>();

            char letter = 'A';

            for (int i = 0; i < 26; i++)
            {
                list.Add(Convert.ToString(letter), i);
                letter++;
            }
            char secondLetter = 'a';
            letter = 'A';
            for (int i = 26; i < 168; i++)
            {
                list.Add(string.Concat(Convert.ToString(secondLetter), Convert.ToString(letter)), i);
                letter++;
                if ((i + 1) % 26 == 0)
                {
                    letter = 'A';
                    secondLetter++;
                }
            }

            string current = string.Empty;

            foreach (var symbol in input)
            {

                if (symbol >= 'A' && symbol <= 'Z')
                {
                    
                }
            }
        }
    }
}
