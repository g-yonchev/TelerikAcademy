using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger i = 0;
        BigInteger result = 1;
        BigInteger moreThan10Result = 1;
        int count = 1;
        while (true)
        {
            string number = Console.ReadLine();

            if (number == "END")
            {
                break;
            }
            if (count <= 10)
            {
                if (i % 2 == 0)
                {
                    if (!(number == "0"))
                    {
                        foreach (char digit in number)
                        {
                            if (digit >= '1' && digit <= '9')
                            {
                                string toString = Convert.ToString(digit);
                                int toInt = int.Parse(toString);
                                result *= toInt;
                            }
                        }
                    }

                }
                i++;
                count++;
            }
            else
            {
                if (i % 2 == 0)
                {
                    if (!(number == "0"))
                    {
                        foreach (char digit in number)
                        {
                            if (digit >= '1' && digit <= '9')
                            {
                                string toString = Convert.ToString(digit);
                                int toInt = int.Parse(toString);
                                moreThan10Result *= toInt;
                            }
                        }
                    }
                }
                i++;
            }
        }
        Console.WriteLine(result);
        if (count > 10)
        {
            Console.WriteLine(moreThan10Result);
        }
    }
}