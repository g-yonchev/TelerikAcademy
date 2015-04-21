namespace SolveTasks
{
    using System;
    using System.Text;
    using System.Linq;
    class SolveTasks
    {
        /*  Problem 13. Solve tasks

            Write a program that can solve these tasks:
                * Reverses the digits of a number
                * Calculates the average of a sequence of integers
                * Solves a linear equation a * x + b = 0
         
            Create appropriate methods.
            Provide a simple text-based menu for the user to choose which task to solve.
         
            Validate the input data:
                * The decimal number should be non-negative
                * The sequence should not be empty
                * a should not be equal to 0
        */

        static void Main()
        {

            Console.WriteLine("Task a: Reverses the digits of a number.");
            Console.WriteLine("Task b: Calculates the average of a sequence of integers.");
            Console.WriteLine("Task c: Solves a linear equation a * x + b = 0.");
            Console.WriteLine();

            ChoosingTask();
        }

        static void ChoosingTask()
        {
            Console.Write("Choose a task (Press \"E\" to escape): ");
            string task = Console.ReadLine();

            if (task == "A" || task == "a")
            {
                TaskA();
            }
            else if (task == "B" || task == "b")
            {
                TaskB();
            }
            else if (task == "C" || task == "c")
            {
                TaskC();
            }
            else if (task == "E" || task == "e")
            {
                return;
            }
            else
            {
                Console.WriteLine("Wrong choise!");
            }
            ChoosingTask();
        }

        static void TaskA()
        {
            Console.Write("Enter non-negative decimal number: ");
            char[] number = Console.ReadLine()
                .Select(x => Convert.ToChar(x))
                .ToArray();

            if (!char.IsDigit(number[0]))
            {
                Console.WriteLine("The number should be non-negative!");
                TaskA();
            }
            else
            {
                int indexOfPoint = 0;
                var reversed = new StringBuilder();

                for (int i = number.Length - 1; i >= 0; i--)
                {
                    if (char.IsDigit(number[i]))
                    {
                        reversed.Append(number[i]);
                    }
                    else
                    {
                        indexOfPoint = i;
                    }
                }

                reversed.Insert(indexOfPoint, '.');

                Console.WriteLine("Reversed number: " + reversed.ToString());
            }
        }

        static void TaskB()
        {

            Console.WriteLine("Enter a sequence of integer numbers, separated by space and/or coma:");
            string sequence = Console.ReadLine();

            if (sequence == string.Empty)
            {
                Console.WriteLine("The sequence should not be empty!");
                TaskB();
            }
            else
            {
                int[] arrayOfIntegers = sequence
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

                long sum = 0;
                foreach (var integer in arrayOfIntegers)
                {
                    sum += integer;
                }
                decimal average = (decimal)sum / (decimal)arrayOfIntegers.Length;

                Console.WriteLine("The average of the integers: {0}", average);
            }
        }

        static void TaskC()
        {
            Console.Write("Enter a: ");
            decimal a = decimal.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a should not be equal to 0!");
                TaskC();
            }
            else
            {
                Console.Write("Enter b: ");
                decimal b = decimal.Parse(Console.ReadLine());

                decimal x = -1 * (b / a);
                Console.WriteLine("Linear equation: {0} * x + {1} = 0", a, b);
                Console.WriteLine("x = {0}", x);
            }
        }
    }
}
