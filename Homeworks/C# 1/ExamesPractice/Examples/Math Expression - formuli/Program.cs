using System;

class Program
{
    static void Main()
    {
        // input
        decimal N = decimal.Parse(Console.ReadLine());
        decimal M = decimal.Parse(Console.ReadLine());
        decimal P = decimal.Parse(Console.ReadLine());

        // solution

        decimal nom = (N * N) + (1 / (M * P) + 1337);

        decimal denom = N - (128.523123123m * P);


        int mod = (int)(M % 180);
        decimal sin = (decimal)Math.Sin(mod);



        decimal result = (nom / denom) + sin;
        // output
         Console.WriteLine("{0:F6}", result);



    }
}