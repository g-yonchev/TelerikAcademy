// TODO


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Three_in_One
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task one
            string inputOne = Console.ReadLine();
            //string inputTwostring = Console.ReadLine();
            //int inputTwoInt = int.Parse(Console.ReadLine());
            //string inputThree = Console.ReadLine();

            //int resultOne;
            //int resultTwo;
            //int resultThree;
            
            TaskOne(inputOne);
        }

        static int TaskOne(string input) // 18,20,19,18
        {
            // int result = 0;

            int[] array = input
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Array.Sort(array);

            int needenElement;
            for (int i = array.Length; i >= 0 ; i--)
            {
                if (array[i] <= 21)
                {
                    needenElement = array[i];
                    if (needenElement == array[i + 1])
                    {
                        
                    }
                }
            }

            return 0;
        }
    }
}

