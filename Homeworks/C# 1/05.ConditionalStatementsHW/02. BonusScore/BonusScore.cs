namespace BonusScore
{
    using System;
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());

            Console.WriteLine(GetResult(score));
        }

        private static string GetResult(int score)
        {
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    return (score * 10).ToString();
                case 4:
                case 5:
                case 6:
                    return (score * 100).ToString();
                case 7:
                case 8:
                case 9:
                    return (score * 1000).ToString();
                default:
                    return "Invalid score.";
            }
        }
    }
}