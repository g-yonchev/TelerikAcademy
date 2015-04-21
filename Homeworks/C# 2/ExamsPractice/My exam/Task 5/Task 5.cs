using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Task5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        SortedSet<int> existedDigits = new SortedSet<int>();

        //int[] arr = new int[10];

        //for (int i = 0; i < number; i++)
        //{
        //    string line = Console.ReadLine();


        //    if (line.Contains("before"))
        //    {
        //        arr[int.Parse(line[line.Length - 1].ToString())] += arr[int.Parse(line[0].ToString())] + 1;
        //    }

        //}

        //foreach (var item in existedDigits)
        //{
        //    Console.Write(item);
        //}
        //Console.WriteLine();



        int[,] numbers = new int[number + 1, 10];


        for (int k = 0; k < 10; k++)
        {
            numbers[0, k] = 1;
        }

        // number 1st row = zeros
        for (int i = 1; i <= number; i++)
        {


            int indexOne = 0;
            int indexTwo = 0;

            string line = Console.ReadLine();

            existedDigits.Add(int.Parse(line[0].ToString()));
            existedDigits.Add(int.Parse(line[line.Length - 1].ToString()));

            if (line.Contains("before"))
            {
                indexOne = int.Parse(line[0].ToString());
                indexTwo = int.Parse(line[line.Length - 1].ToString());
            }
            else
            {
                indexOne = int.Parse(line[line.Length - 1].ToString());
                indexTwo = int.Parse(line[0].ToString());
            }
            for (int j = 0; j < 10; j++)
            {

                numbers[i, j] = numbers[i - 1, j];

            }


            numbers[i, indexTwo] = numbers[i - 1, indexTwo] + numbers[i, indexOne];
            numbers[i, indexOne] = numbers[i, indexTwo] - 1;
        }

        bool[] isEx = new bool[10];

        for (int i = 0; i < 10; i++)
        {
            if (existedDigits.Contains(i))
            {
                isEx[i] = true;
            }
        }






    }
}
