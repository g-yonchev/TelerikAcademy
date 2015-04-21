using System;

class Program
{
    static void Main()
    {
        // !!!!!!!!!!!!!Sushtata kato 2-4-8. za komentari pogledi tam.

        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long r;

        if (b == 3)
        {
            r = a + c;
            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(r % 3);
                Console.WriteLine(r);
            }
        }
        if (b == 6)
        {
            r = a * c;
            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(r % 3);
                Console.WriteLine(r);
            }
        }
        if (b == 9)
        {
            r = a % c;
            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(r % 3);
                Console.WriteLine(r);
            }
        }
    }
}