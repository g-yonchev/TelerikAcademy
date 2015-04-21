using System;

class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());

        double a = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double inMachine = n1 * 0.05 + n2 * 0.10 + n3 * 0.20 + n4 * 0.50 + n5 * 1.00;

        if (a >= p)
        {
            double change = a - p;
            if (inMachine >= change)
            {
                Console.WriteLine("Yes {0:F2}", inMachine - change);
            }
            else
            {
                Console.WriteLine("No {0:F2}", change - inMachine);
            }
        }
        else
        {
            Console.WriteLine("More {0:F2}", p-a);
        }
    }
}