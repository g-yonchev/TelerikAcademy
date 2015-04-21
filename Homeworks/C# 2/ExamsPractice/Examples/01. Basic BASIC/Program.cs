using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Basic_BASIC
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentLine = Console.ReadLine();

            List<string> lines = new List<string>();

            int V =0 , W = 0, X = 0, Y = 0, Z = 0;

            while (currentLine != "RUN")
            {
                string[] line = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                lines.Add(line);




                currentLine = Console.ReadLine();
            }

        }
    }
}
