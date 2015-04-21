namespace IndexOfLetters
{
    using System;
    using System.Collections.Generic;
    class IndexOfLetters
    {
        /*  Problem 12. Index of letters

            Write a program that creates an array containing all letters from the alphabet (A-Z).
            Read a word from the console and print the index of each of its letters in the array.
        */

        static void Main()
        {
            char[] alphabet = new char[26];
            char letter = 'A';

            for (int i = 0; i < alphabet.Length; i++, letter++)
            {
                alphabet[i] = letter;
            }

            Console.WriteLine("An array containing all letters from the alphabet (A-Z):");
            Console.WriteLine(new string(alphabet));
            Console.WriteLine();

            Console.Write("Enter a word with capital letters: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i] + " = ");
                int indexPosition = Array.IndexOf(alphabet, word[i]);

                if (indexPosition != -1)
                {
                    Console.WriteLine(indexPosition);
                }
                else
                {
                    Console.WriteLine("ONLY CAPITAL LETTERS :) ");
                }
            }
        }
    }
}