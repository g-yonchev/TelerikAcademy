using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();

        for (int i = 0; i < number.Length; i++)
        {
            int counterEven = 0;
            int counterOdd = 0;
            int counter = 0;
            foreach (char digit in number)
            {
                string digitString = Convert.ToString(digit);
                double digitInt = double.Parse(digitString);
                if (number.Length % 2 == 0)
                {
                    if (counter % 2 == 0)
                    {
                        for (int j = 1; j <= number.Length; j += 2)
                        {
                            digitInt *= Math.Pow(j, 2);
                            counterEven += digitInt;
                        }
                        counter++;
                    }
                }
            }
        }

    }
}