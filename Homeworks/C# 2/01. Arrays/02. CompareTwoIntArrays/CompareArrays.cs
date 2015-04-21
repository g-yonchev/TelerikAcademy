namespace CompareTwoIntArrays
{
    using System;
    class CompareArrays
    {
        /*  Problem 2. Compare arrays

            Write a program that reads two integer arrays from the console and compares them element by element.
        */

        static void Main()
        {
            Console.Write("Enter length of first array: ");
            int firstLength = int.Parse(Console.ReadLine());

            Console.Write("Enter length of second array: ");
            int secondLength = int.Parse(Console.ReadLine());

            int[] firstArray = new int[firstLength];
            Console.WriteLine("Elemets of first array:");
            InitializeArrays(firstArray);

            int[] secondArray = new int[secondLength];
            Console.WriteLine("Elemets of second array:");
            InitializeArrays(secondArray);

            if (!(firstLength == secondLength))
            {
                Console.WriteLine("The arrays are with different length and cannot be equals!");
            }
            else
            {
                CompareTwoArrays(firstArray, secondArray);
            }
        }

        static void InitializeArrays(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void CompareTwoArrays(int[] firstArray, int[] secondArray)
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
