/*  Problem 21. Letters count

    Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
*/

namespace LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class LettersCount
    {
        static void Main()
        {
            Console.Write("Enter some string: ");
            string text = Console.ReadLine();
            text = text.ToUpper();

            var letters = new Dictionary<char, int>();


            foreach (var letter in text)
            {
                if (!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 1);
                }
                else
                {
                    letters[letter]++;
                }
            }

            if (letters.Count == 0)
            {
                Console.WriteLine("You entered no letters!");
            }
            else
            {
                foreach (var letter in letters)
                {
                    Console.WriteLine("{0}: {1} time(s).", letter.Key, letter.Value);                    
                }
            }
        }
    }
}
