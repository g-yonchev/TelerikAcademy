using System;

class Program
{
    static void Main()
    {
        // izpolzvai long, zashtoto pri golemi chisla dava overflow i dava otricatelni stoinosti.

        long a = int.Parse(Console.ReadLine());
        long b = int.Parse(Console.ReadLine());
        long c = int.Parse(Console.ReadLine());
        long r;

        if (b == 2)
        {
            // vkarai r vuv vseki if.

            r = a % c;
            if (r % 4 == 0)
            {
                Console.WriteLine(r / 4);
            }
            else
            {
                Console.WriteLine(r % 4);
            }
            Console.WriteLine(r);
        }

        if (b == 4)
        {
            r = a + c;
            if (r % 4 == 0)
            {
                Console.WriteLine(r / 4);
            }
            else
            {
                Console.WriteLine(r % 4);
            }
            Console.WriteLine(r);
        }

        if (b == 8)
        {
            r = a * c;
            if (r % 4 == 0)
            {
                Console.WriteLine(r / 4);
            }
            else
            {
                Console.WriteLine(r % 4);
            }
            Console.WriteLine(r);
        }
    }
}
