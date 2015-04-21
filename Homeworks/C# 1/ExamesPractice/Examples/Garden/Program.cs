using System;

class Program
{
    static void Main()
    {
        decimal tomatoSeed = decimal.Parse(Console.ReadLine());
        decimal tomatoArea = decimal.Parse(Console.ReadLine());

        decimal cucumberSeed = decimal.Parse(Console.ReadLine());
        decimal cucumberArea = decimal.Parse(Console.ReadLine());

        decimal potatoSeed = decimal.Parse(Console.ReadLine());
        decimal potatoArea = decimal.Parse(Console.ReadLine());

        decimal carrotSeed = decimal.Parse(Console.ReadLine());
        decimal carrotArea = decimal.Parse(Console.ReadLine());

        decimal cabbageSeed = decimal.Parse(Console.ReadLine());
        decimal cabbageArea = decimal.Parse(Console.ReadLine());

        decimal beanSeed = decimal.Parse(Console.ReadLine());

        decimal Cost = tomatoSeed * 0.5M + cucumberSeed * 0.4M + potatoSeed * 0.25M + carrotSeed * 0.6M + cabbageSeed * 0.3M + beanSeed * 0.4M;

        decimal Area = 250 - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);

        Console.WriteLine("Total costs: {0:F2}", Cost);

        if (Area == 0)
        {
            Console.WriteLine("No area for beans");
        }
        if (Area > 0)
        {
            Console.WriteLine("Beans area: {0:F0}", Area);
        }
        if (Area < 0)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}