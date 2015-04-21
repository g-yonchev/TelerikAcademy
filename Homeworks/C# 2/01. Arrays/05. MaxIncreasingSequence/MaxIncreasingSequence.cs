﻿namespace MaxIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    class MaxIncreasingSequence
    {
        /*  Problem 5. Maximal increasing sequence

            Write a program that finds the maximal increasing sequence in an array.
            Example:

            input	                        result
            3, 2, 3, 4, 2, 2, 4	            2, 3, 4
        */

        static void Main()
        {
            Console.Write("Enter a length of the array: ");
            int N = int.Parse(Console.ReadLine());

            int[] nums = new int[N];
            Console.WriteLine("Enter {0} number(s) to array:", N);
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            List<int> bestSequence = FindMaxIncreasingSequence(nums);

            Console.WriteLine("The maximal sequence of increasing elements is: " + string.Join(", ", bestSequence));
        }

        static List<int> FindMaxIncreasingSequence(int[] nums)
        {
            if (nums.Length == 1)
            {
                return new List<int>() { nums[0] };
            }

            List<int> maxIncreasingSequence = new List<int>() { nums[0] };
            List<int> bestSequence = new List<int>();

            int currElement = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > currElement)
                {
                    maxIncreasingSequence.Add(nums[i]);
                    currElement = nums[i];
                }
                else
                {
                    currElement = nums[i];
                    maxIncreasingSequence = new List<int>() { nums[i] };
                }

                if (maxIncreasingSequence.Count >= bestSequence.Count)
                {
                    bestSequence = new List<int>(maxIncreasingSequence);
                }
            }

            if (bestSequence.Count == 1 && bestSequence[0] == nums[nums.Length - 1])
            {
                return new List<int>() { nums[0] };
            }
            return bestSequence;
        }
    }
}