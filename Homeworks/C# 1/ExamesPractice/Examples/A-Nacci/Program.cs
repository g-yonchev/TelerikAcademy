using System;

class Program
{
    static void Main()
    {
        int shift = 64;
        string firstMember = Console.ReadLine();
        int first = firstMember[0] - shift;
        string secondMember = Console.ReadLine();
        int second = secondMember[0] - shift;

        int rowNumber = int.Parse(Console.ReadLine());


        int next = 0;

        Console.WriteLine((char)(first + shift));

        for (int i = 2; i <= rowNumber; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (second > 26)
                {
                    second %= 26; 
                }
                Console.Write((char)(second + shift) + new string(' ', i - 2));
                next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine();
        }
    }
}