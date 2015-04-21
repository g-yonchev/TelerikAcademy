namespace SubsetWithSumS
{
    using System;
    using System.Linq;
    class SubsetWithSumS
    {
        /*  Problem 16.* Subset with sum S

            We are given an array of integers and a number S.
            Write a program to find if there exists a subset of the elements of the array that has a sum S.

            Example:
            input array	                S	    result
            2, 1, 2, 4, 3, 5, 2, 6	    14	    yes
        */

        static void Main()
        {
            Console.Write("Enter elements of an array separated by space and/or coma: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Enter a sum S: ");
            long S = long.Parse(Console.ReadLine());

            long currentSum = 0;
            int count = 0;

            for (int i = 1; i <= (int)Math.Pow(2, array.Length) - 1; i++)
            {
                currentSum = 0;
                string template = Convert.ToString(i, 2).PadLeft(array.Length, '0');

                for (int j = 0; j < template.Length; j++)
                {
                    if (template[j].ToString() == "1")
                    {
                        currentSum += array[j];
                    }
                }
                if (currentSum == S)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Yes, {0} combinations of elements in the array [{1}] have a sum of {2}.", count, string.Join(", ", array), S);
            }
        }
    }
}
