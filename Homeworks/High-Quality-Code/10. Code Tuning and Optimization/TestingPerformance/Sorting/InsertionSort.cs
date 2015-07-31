namespace Sorting
{
    using System;
    using System.Linq;

    using DisplayExecutionTime;

    public class InsertionSorting
    {
        public static void InsertionSortArray()
        {
            Console.WriteLine("Insertion sort");
            int[] array = Sorting.GenerateRandomArray();
            int[] intArray = new int[100];
            Array.Copy(array, intArray, 100);

            Console.Write("Sort array of random int:    ");
            DisplayExecutionTime.Run(() =>
            {
                intArray = InsertionSort<int>(intArray);
            });

            double[] doubleArray = new double[100];
            Array.Copy(array, doubleArray, 100);

            Console.Write("Sort array of random double: ");
            DisplayExecutionTime.Run(() =>
            {
                doubleArray = InsertionSort<double>(doubleArray);
            });

            string[] stringArray = new string[100];
            for (int count = 0; count < 100; count++)
            {
                stringArray[count] = array[count].ToString();
            }

            Console.Write("Sort array of random string: ");
            DisplayExecutionTime.Run(() =>
            {
                stringArray = InsertionSort<string>(stringArray);
            });
        }

        private static T[] InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int iteration = 1; iteration < 100; iteration++)
            {
                T correntNumber = array[iteration];
                int currentPosition = iteration - 1;
                while (currentPosition >= 0 && correntNumber.CompareTo(array[currentPosition]) < 0)
                {
                    T exchangeNumber = array[currentPosition + 1];
                    array[currentPosition + 1] = array[currentPosition];
                    array[currentPosition] = exchangeNumber;
                    currentPosition--;
                }
            }

            return array;
        }
    }
}
