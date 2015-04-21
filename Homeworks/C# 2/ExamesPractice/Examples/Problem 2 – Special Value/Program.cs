using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] jaj = new int[n][];
        bool[][] visited = new bool[n][];

        for (int i = 0; i < n; i++)
        {
            int[] line = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            jaj[i] = line;
            visited[i] = new bool[line.Length];

        }

        int maxSteps = 0;
        int lastCell = 0;
        int specialValue = 0;
        int maxValue = 0;

        for (int i = 0; i < jaj[0].Length; i++)
        {
            int currentRow = 0;
            int currentCell = jaj[0][i];
            
            visited[0][i] = true;
            

            int currentSteps = 1;

            if (currentCell < 0)
            {
                maxSteps = currentSteps;
                specialValue = currentSteps + Math.Abs(currentCell);

                if (specialValue > maxValue)
                {
                    maxValue = specialValue;
                }
                specialValue = 0;
                GetDefalst(visited, n);
                continue;
            }


            while (true)
            {
                currentSteps++;
                currentRow++;
                currentRow = currentRow % n;

                // !!!!!!!!
                if (visited[currentRow][currentCell])
                {
                    break;
                }
                visited[currentRow][currentCell] = true;

                currentCell = jaj[currentRow][currentCell];

                

                if (currentCell < 0)
                {
                    specialValue = currentSteps + Math.Abs(currentCell);

                    if (specialValue > maxValue)
                    {
                        maxValue = specialValue;
                    }
                    specialValue = 0;
                    break;
                }
            }

            GetDefalst(visited, n);

        }
        Console.WriteLine(maxValue);



    }

    static void GetDefalst(bool[][] visited, int n)
    {
        for (int i = 0; i < n; i++)
        {
            visited[i] = new bool[visited[i].Length];
        }
    }
}