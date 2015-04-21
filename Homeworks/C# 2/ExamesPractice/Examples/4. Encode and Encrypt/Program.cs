using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Encode_and_Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string chyper = Console.ReadLine();

            string encrypt = string.Empty;

            if (message.Length >= chyper.Length)
            {
                encrypt = BiggerMessage(message, chyper);
            }
            else
            {
                encrypt = BiggerChyper(message, chyper);
            }

            string encode = Encode(encrypt);

            string result = encode + chyper + Convert.ToString(chyper.Length);
            Console.WriteLine(result);
        }

        static string Encode(string code)
        {
            var result = new StringBuilder();

            int counter = 0;

            for (int i = 0; i < code.Length; i++)
            {
                
            }
            


            return result.ToString();
        }

        static string BiggerChyper(string msg, string chyper)
        {
            var builder = new StringBuilder();
            builder.Append(msg);

            for (int i = 0; i < chyper.Length; i++)
            {
                int msgChar = builder[i % msg.Length] - 'A';
                int chyperChar = chyper[i] - 'A';

                int xor = msgChar ^ chyperChar;
                xor += 65;
                builder.Insert(i % msg.Length, (char)xor);
                builder.Remove(i % msg.Length + 1, 1);
            }



            return builder.ToString();

        }

        static string BiggerMessage(string msg, string chyper)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < msg.Length; i++)
            {
                int msgChar = msg[i] - 'A';
                int chyperChar = 0;

                if (chyper.Length - 1 < i)
                {
                    int index = i % chyper.Length;
                    chyperChar = chyper[index] - 'A';
                }
                else
                {
                    chyperChar = chyper[i] - 'A';
                }

                int xor = msgChar ^ chyperChar;
                xor += 65;
                builder.Append((char)xor);
            }

            return builder.ToString();
        }
    }
}
