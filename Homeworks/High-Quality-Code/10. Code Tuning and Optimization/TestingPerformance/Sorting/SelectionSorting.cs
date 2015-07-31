namespace Sorting
{
    using System;

    using DisplayExecutionTime;

    public class SelectionSorting
    {
        public static void SelectionSortArray()
        {
            Console.WriteLine("Selection sort");
            int[] sortedArray = new int[100];
            for (int count = 0; count < 100; count++)
            {
                sortedArray[count] = count;
            }

            Console.Write("Sort array of sorted int:    ");
            DisplayExecutionTime.Run(() =>
            {
                sortedArray = SelectionSort<int>(sortedArray, int.MaxValue);
            });

            int[] reversedArray = new int[100];
            for (int count = 0; count < 100; count++)
            {
                reversedArray[count] = 100 - count;
            }

            Console.Write("Sort array of reversed int:  ");
            DisplayExecutionTime.Run(() =>
            {
                reversedArray = SelectionSort<int>(reversedArray, int.MaxValue);
            });

            Console.Write("Sort array of random int:    ");
            int[] array = Sorting.GenerateRandomArray();
            int[] intArray = new int[100];
            Array.Copy(array, intArray, 100);

            DisplayExecutionTime.Run(() =>
            {
                intArray = SelectionSort<int>(intArray, int.MaxValue);
            });

            double[] doubleArray = new double[100];
            Array.Copy(array, doubleArray, 100);

            Console.Write("Sort array of random double: ");
            DisplayExecutionTime.Run(() =>
            {
                doubleArray = SelectionSort<double>(doubleArray, double.MaxValue);
            });

            string[] stringArray = new string[100];
            for (int count = 0; count < 100; count++)
            {
                stringArray[count] = array[count].ToString();
            }

            Console.Write("Sort array of random string: ");
            DisplayExecutionTime.Run(() =>
            {
                stringArray = SelectionSort<string>(stringArray, "9999999");
            });
        }

        private static T[] SelectionSort<T>(T[] array, T maxValue) where T : IComparable
        {
            T minNumber = maxValue;
            int currentPosition = 0;
            for (int iteration = 1; iteration < 100; iteration++)
            {
                for (int position = iteration - 1; position < 100; position++)
                {
                    if (array[position].CompareTo(minNumber) < 0)
                    {
                        minNumber = array[position];
                        currentPosition = position;
                    }
                }

                T exchangeNumber = array[iteration - 1];
                array[iteration - 1] = array[currentPosition];
                array[currentPosition] = exchangeNumber;
                minNumber = maxValue;
                currentPosition = 0;
            }

            return array;
        }
    }
}
