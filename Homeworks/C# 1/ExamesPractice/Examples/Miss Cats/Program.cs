using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cats = new int[11];
        for (int i = 0; i < n; i++)
        {
            int mark = int.Parse(Console.ReadLine());

            cats[mark]++;
        }
        int max = 0;
        int cat = 0;
        for (int i = 1; i < cats.Length; i++)
        {
            int currentValue = cats[i];
            if (currentValue > max)
            {
                max = currentValue;
                cat = i;
            }
        }
        Console.WriteLine(cat);
    }
}
