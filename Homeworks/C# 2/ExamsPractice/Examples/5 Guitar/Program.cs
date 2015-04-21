using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Guitar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] changing = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int startVolume = int.Parse(Console.ReadLine());
            int maxVolume = int.Parse(Console.ReadLine());

            int lastSong = ChangingVolume(changing, startVolume, maxVolume);
            Console.WriteLine(lastSong);
        }

        static int ChangingVolume(int[] changing, int startVolume, int maxVolume)
        {
            int[,] matrix = new int[changing.Length + 1, maxVolume + 1];

            matrix[0, startVolume] = 1;
            int count = 0;

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i - 1, j] == 1)
                    {
                        if (j + changing[i - 1] >= 0 && j + changing[i - 1] <= maxVolume)
                        {
                            matrix[i, j + changing[i - 1]] = 1;
                        }

                        if (j - changing[i - 1] >= 0 && j - changing[i - 1] <= maxVolume)
                        {
                            matrix[i, j - changing[i - 1]] = 1;
                        }
                    }
                }
            }


            int[] lastSong = new int[maxVolume + 1];
            
            for (int i = 0; i < maxVolume + 1; i++)
            {
                lastSong[i] = matrix[changing.Length, i];
            }

            int index = maxVolume;

            foreach (var cell in lastSong)
            {
                if (lastSong[index] == 1)
                {
                    return index;
                }
                index--;
            }
            return -1;
        }
    }
}
