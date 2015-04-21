/*  Problem 7. Encode/decode

    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
*/

namespace EncodeDecode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class EncodeDecode
    {
        static void Main()
        {
            Console.WriteLine("Enter the text you want to endcode:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter the cipher (try with digits):");
            string cipher = Console.ReadLine();

            var result = new StringBuilder();
            int indexCipher = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (indexCipher == cipher.Length)
                {
                    indexCipher = 0;
                } 
                
                int encodedChar = text[i] ^ cipher[indexCipher];
                result.Append((char)encodedChar);
                indexCipher++;
            }

            Console.WriteLine("The result: " + result.ToString());
        }
    }
}
