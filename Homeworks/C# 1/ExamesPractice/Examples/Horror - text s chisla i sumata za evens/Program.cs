using System;

class Program
{
    static void Main()
    {
        // sushtata kato nightmare. za komentri pogledni tam.

        string text = Console.ReadLine();


        int counter = 0;
        int evenCounter = 0;
        int sum = 0;

        foreach (char symbol in text)
        {
            if (evenCounter % 2 == 0)
            {
                if (symbol >= '0' && symbol <= '9')
                {
                    string a = Convert.ToString(symbol);
                    int b = int.Parse(a);
                    sum += b;
                    counter++;
                }
            }
            evenCounter++;
        }
        Console.WriteLine("{0} {1}", counter, sum);
    }
}