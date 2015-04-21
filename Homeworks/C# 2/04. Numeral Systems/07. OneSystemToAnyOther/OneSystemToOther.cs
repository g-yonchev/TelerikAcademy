namespace OneSystemToAnyOther
{
    using System;
    class OneSystemToOther
    {
        /*  Problem 7. One system to any other

            Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
        */

        static void Main()
        {
            Console.Write("Choose the first numeral system (in range: 2 < n < 16): ");
            int firstSystem = int.Parse(Console.ReadLine());
            Console.Write("Choose the second numeral system (in range: 2 < n < 16): ");
            int secondSystem = int.Parse(Console.ReadLine());
            Console.Write("Enter number after convert = ");
            string number = Console.ReadLine();
            Console.WriteLine("The number is {0}", OneNumeralSystemToOtherNumeralSystem(firstSystem, secondSystem, number));
        }

        static string OneNumeralSystemToOtherNumeralSystem(int firstSystem, int secondSystem, string number)
        {
            long decimalNum = BaseToDecimal(number, firstSystem);
            string convertNumber = DecimalToBase(decimalNum, secondSystem);
            return convertNumber;
        }
        // Convert Decimal to Base
        static string DecimalToBase(long decNum, int numeralSystem)
        {
            string result = "";
            while (decNum > 0)
            {
                long digit = decNum % numeralSystem;
                if (digit >= 0 && digit <= 9)
                {
                    result = (char)(digit + '0') + result;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    result = (char)(digit - 10 + 'A') + result;
                }
                decNum = decNum / numeralSystem;
            }
            return result;
        }
        // Convert Base to Decimal
        static long BaseToDecimal(string number, int numeralSystem)
        {
            long decimalNum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;
                int position = number.Length - i - 1;
                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else if (number[i] >= 'A' && number[i] <= 'F')
                {
                    digit = number[i] - 'A' + 10;
                }
                decimalNum += digit * (long)Math.Pow(numeralSystem, position);
            }
            return decimalNum;
        }
    }
}



