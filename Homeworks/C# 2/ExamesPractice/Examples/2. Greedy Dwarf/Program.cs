using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Greedy_Dwarf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valley = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int numbersOfpatterns = int.Parse(Console.ReadLine());

            long maxCoins = long.MinValue;

            for (int i = 0; i < numbersOfpatterns; i++)
            {
                int[] currentPattern = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

                int currentPositionValey = 0;
                int currentPositionParrent = 0;
                long currentCoins = 0;

                int[] isGet = new int[valley.Length];

                while (true)
                {
                    currentCoins += (long)valley[currentPositionValey];

                    isGet[currentPositionValey] = -1;
                    if (currentCoins > maxCoins)
                    {
                        maxCoins = currentCoins;
                    }

                    currentPositionValey += currentPattern[currentPositionParrent];

                    currentPositionParrent++;
                    if (currentPositionParrent == currentPattern.Length)
                    {
                        currentPositionParrent = 0;
                    }

                    if (currentPositionValey < 0 || currentPositionValey > valley.Length - 1 || isGet[currentPositionValey] == -1)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(maxCoins);
        }
    }
}
