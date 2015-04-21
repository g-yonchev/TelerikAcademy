﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Joro_the_Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] terrain = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int maxJumps = 1;

            bool[] visited = new bool[terrain.Length];

            for (int i = 0; i < terrain.Length; i++)
            {
                int startIndex = i;
                int startCell = terrain[startIndex];
                int currentJumps = 1;

                for (int jump = 1; jump < terrain.Length - 1; jump++)
                {
                    int nextIndex = (startIndex + jump) % terrain.Length;
                    int nextCell = terrain[nextIndex];
                    visited[startIndex] = true;

                    while (startCell < nextCell && visited[nextIndex] == false)
                    {
                        currentJumps++;
                        visited[nextIndex] = true;
                        if (currentJumps > maxJumps)
                        {
                            maxJumps = currentJumps;
                        }

                        startIndex = nextIndex;
                        startCell = nextCell;

                        nextIndex = (startIndex + jump) % terrain.Length;
                        nextCell = terrain[nextIndex];
                    }
                    visited = new bool[terrain.Length];
                    currentJumps = 1;
                    startIndex = i;
                    startCell = terrain[startIndex];
                }
            }

            Console.WriteLine(maxJumps);

        }
    }
}