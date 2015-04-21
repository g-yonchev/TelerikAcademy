using System;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();

        decimal sum = 0.0M; 
        foreach (char symbol in a)
        {
            if (symbol == '=')
            {
                break;
            }
            if (symbol == '(')
            {
               symbol = symbol.GetHashCode;
            }
        }
        Console.WriteLine("{0:F3}", sum);
    }
}