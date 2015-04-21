namespace CompareTwoCharArrays
{
    using System;
    class CompareCharArrays
    {
        /*  Problem 3. Compare char arrays

            Write a program that compares two char arrays lexicographically (letter by letter).
        */

        static void Main()
        {
            Console.Write("Enter length of first char array: ");
            int firstLength = int.Parse(Console.ReadLine());

            Console.Write("Enter length of second char array: ");
            int secondLength = int.Parse(Console.ReadLine());

            char[] firstCharArray = new char[firstLength];
            Console.WriteLine("Elemets of first char array:");
            InitializeArrays(firstCharArray);

            char[] secondCharArray = new char[secondLength];
            Console.WriteLine("Elemets of second char array:");
            InitializeArrays(secondCharArray);

            if (!(firstLength == secondLength))
            {
                Console.WriteLine("The arrays are with different length and cannot be equals!");
            }
            else
            {
                CompareTwoCharArrays(firstCharArray, secondCharArray);
            }
        }

        static void InitializeArrays(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = char.Parse(Console.ReadLine());
            }
        }
        
        static void CompareTwoCharArrays(char[] firstArray, char[] secondArray)
        {
            bool areEquals = true;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEquals = false;
                    break;
                }
            }
            Console.WriteLine("Are they equals? --> {0}", areEquals);
        }
    }
}
