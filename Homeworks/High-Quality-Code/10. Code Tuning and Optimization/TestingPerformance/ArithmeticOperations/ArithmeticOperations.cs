namespace AritmeticOperations
{
    using System;

    using DisplayExecutionTime;

    public class ArithmeticOperations
    {
        public static void Add()
        {
            Console.Write("Addition of int:     ");
            DisplayExecutionTime.Run(() =>
            {
                int sum = 0;
                for (int i = 0; i < 1000000; i++)
                {
                    sum += 100;
                }
            });

            Console.Write("Addition of long:    ");
            DisplayExecutionTime.Run(() =>
            {
                long sum = 0L;
                for (int i = 0; i < 1000000; i++)
                {
                    sum += 100L;
                }
            });

            Console.Write("Addition of float:   ");
            DisplayExecutionTime.Run(() =>
            {
                float sum = 0f;
                for (int i = 0; i < 1000000; i++)
                {
                    sum += 100f;
                }
            });

            Console.Write("Addition of double:  ");
            DisplayExecutionTime.Run(() =>
            {
                double sum = 0.0;
                for (int i = 0; i < 1000000; i++)
                {
                    sum += 100.0;
                }
            });

            Console.Write("Addition of decimal: ");
            DisplayExecutionTime.Run(() =>
            {
                decimal sum = 0m;
                for (int i = 0; i < 1000000; i++)
                {
                    sum += 100m;
                }
            });
        }

        public static void Subtract()
        {
            Console.Write("Subtraction of int:     ");
            DisplayExecutionTime.Run(() =>
            {
                int result = 1000000000;
                for (int i = 0; i < 1000000; i++)
                {
                    result -= 100;
                }
            });

            Console.Write("Subtraction of long:    ");
            DisplayExecutionTime.Run(() =>
            {
                long result = 1000000000L;
                for (int i = 0; i < 1000000; i++)
                {
                    result -= 100L;
                }
            });

            Console.Write("Subtraction of float:   ");
            DisplayExecutionTime.Run(() =>
            {
                float result = 1000000000f;
                for (int i = 0; i < 1000000; i++)
                {
                    result -= 100f;
                }
            });

            Console.Write("Subtraction of double:  ");
            DisplayExecutionTime.Run(() =>
            {
                double result = 1000000000.0;
                for (int i = 0; i < 1000000; i++)
                {
                    result -= 100.0;
                }
            });

            Console.Write("Subtraction of decimal: ");
            DisplayExecutionTime.Run(() =>
            {
                decimal result = 1000000000m;
                for (int i = 0; i < 1000000; i++)
                {
                    result -= 100m;
                }
            });
        }

        public static void Increment()
        {
            Console.Write("Increment of int:     ");
            DisplayExecutionTime.Run(() =>
            {
                int value = 1;
                for (int i = 0; i < 1000000; i++)
                {
                    value++;
                }
            });

            Console.Write("Increment of long:    ");
            DisplayExecutionTime.Run(() =>
            {
                long value = 1L;
                for (int i = 0; i < 1000000; i++)
                {
                    value++;
                }
            });

            Console.Write("Increment of float:   ");
            DisplayExecutionTime.Run(() =>
            {
                float value = 1f;
                for (int i = 0; i < 1000000; i++)
                {
                    value++;
                }
            });

            Console.Write("Increment of double:  ");
            DisplayExecutionTime.Run(() =>
            {
                double value = 1.0;
                for (int i = 0; i < 1000000; i++)
                {
                    value++;
                }
            });

            Console.Write("Increment of decimal: ");
            DisplayExecutionTime.Run(() =>
            {
                decimal value = 1m;
                for (int i = 0; i < 1000000; i++)
                {
                    value++;
                }
            });
        }

        public static void Multiply()
        {
            Console.Write("Multiplication of int:     ");
            DisplayExecutionTime.Run(() =>
            {
                int product = 1;
                for (int i = 0; i < 1000000; i++)
                {
                    product *= 1;
                }
            });

            Console.Write("Multiplication of long:    ");
            DisplayExecutionTime.Run(() =>
            {
                long product = 1L;
                for (int i = 0; i < 1000000; i++)
                {
                    product *= 1L;
                }
            });

            Console.Write("Multiplication of float:   ");
            DisplayExecutionTime.Run(() =>
            {
                float product = 1f;
                for (int i = 0; i < 1000000; i++)
                {
                    product *= 1f;
                }
            });

            Console.Write("Multiplication of double:  ");
            DisplayExecutionTime.Run(() =>
            {
                double product = 1.0;
                for (int i = 0; i < 1000000; i++)
                {
                    product *= 1.0;
                }
            });

            Console.Write("Multiplication of decimal: ");
            DisplayExecutionTime.Run(() =>
            {
                decimal product = 1m;
                for (int i = 0; i < 1000000; i++)
                {
                    product *= 1m;
                }
            });
        }

        public static void Divide()
        {
            Console.Write("Division of int:     ");
            DisplayExecutionTime.Run(() =>
            {
                int result = 1000;
                for (int i = 0; i < 1000000; i++)
                {
                    result /= 1;
                }
            });

            Console.Write("Division of long:    ");
            DisplayExecutionTime.Run(() =>
            {
                long result = 1000L;
                for (int i = 0; i < 1000000; i++)
                {
                    result /= 1L;
                }
            });

            Console.Write("Division of float:   ");
            DisplayExecutionTime.Run(() =>
            {
                float result = 1000f;
                for (int i = 0; i < 1000000; i++)
                {
                    result /= 1f;
                }
            });

            Console.Write("Division of double:  ");
            DisplayExecutionTime.Run(() =>
            {
                double result = 1000.0;
                for (int i = 0; i < 1000000; i++)
                {
                    result /= 1.0;
                }
            });

            Console.Write("Division of decimal: ");
            DisplayExecutionTime.Run(() =>
            {
                decimal result = 1000m;
                for (int i = 0; i < 1000000; i++)
                {
                    result /= 1m;
                }
            });
        }

        public static void Main()
        {
            Add();
            Subtract();
            Increment();
            Multiply();
            Divide();
        }
    }
}