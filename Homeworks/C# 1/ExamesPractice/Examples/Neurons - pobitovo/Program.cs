using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        while (true)
        {
            long line = long.Parse(Console.ReadLine());
            if (line == - 1)
            {
                break;
            }
            int mostLeftBit = -1;  // някакви служебни стойности
            int mostRightBit = -1; // някакви служебни стойности

            // find most left 1
            // find most right 1
            for (int i = 0; i <= 32; i++)
            {
                long mask = 1 << i;
                long lineAndMask = line & mask;
                long bit = lineAndMask >> i; // взимаме бита на изместената позиция
                if (bit == 1)
                {
                    if (mostRightBit == -1) // ако все още до момента не сме намерили 1...
                    {
                        mostRightBit = i; // сетваме позицията i върху най десния индекс.
                    }
                    mostLeftBit = i; // и тук винаги сетваме позиция i върху най левия индекс, и цикъла си цикли... докато не намери последния бит 1. и пак го сетва.
                }
            }

            if (mostLeftBit == -1)
            {
                Console.WriteLine(0);
                continue;
            }

            long result = 0; // tuka se natupkvat edinicite

            // between them set 1 at their 0
            for (int i = mostRightBit; i <= mostLeftBit; i++)
            {
                long mask = 1 << i;
                long nAndMask = line & mask;
                long bit = nAndMask >> i;
                //  if (in the original number --> position i = 0)
                if (bit == 0)
                {
                    // set position i = 1;
                    result = result | mask;
                }
            }
            Console.WriteLine(result);
            
            // проверка дали най левия и десния бит работят.
            // Console.WriteLine(mostRightBit); 
            // Console.WriteLine(mostLeftBit);
        }
    }
}