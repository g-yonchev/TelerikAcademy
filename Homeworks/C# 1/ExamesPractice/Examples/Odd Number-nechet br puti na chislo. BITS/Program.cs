using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        if (N == 1)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(number);
        }
        else
        {
            long[] matrix = new long[N];
            for (int i = 0; i < N; i++)
            {
                matrix[i] = long.Parse(Console.ReadLine());
            }
            int count = 2;
            int index = 2;
            long first = matrix[0] ^ matrix[1];
            while (count < N)
            {
                first = first ^ matrix[index];
                count++;
                index++;
            }
            Console.WriteLine(first);
        }
    }
}