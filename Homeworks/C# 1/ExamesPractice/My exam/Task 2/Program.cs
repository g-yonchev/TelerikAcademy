using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int secret = int.Parse(Console.ReadLine());

        string text = Console.ReadLine();
        int i = 0;
        foreach (char symbol  in text)
        {
            int result = 0;
            
            if (i % 2 == 0)
            {
                if (symbol == '@')
                {
                    break;
                }
                else if ((symbol >= 'A' && symbol <= 'Z') || (symbol >= 'a' && symbol <= 'z'))
                {
                    result = (symbol * secret) + 1000;
                }
                else if (symbol >= '0' && symbol <= '9')
                {
                    result = symbol + secret + 500;
                }
                else
                {
                    result = symbol - secret;
                }
                decimal newresult;
                newresult = (decimal)result / 100;
                Console.WriteLine("{0:F2}", newresult);
            }
            else
            {
                if (symbol == '@')
                {
                    break;
                }
                else if ((symbol >= 'A' && symbol <= 'Z') || (symbol >= 'a' && symbol <= 'z'))
                {
                    result = (symbol * secret) + 1000;
                }
                else if (symbol >= '0' && symbol <= '9')
                {
                    result = symbol + secret + 500;
                }
                else
                {
                    result = symbol - secret;
                }
                result = result * 100;
                Console.WriteLine(result);
            }
            i++;
            
        }



    }
}