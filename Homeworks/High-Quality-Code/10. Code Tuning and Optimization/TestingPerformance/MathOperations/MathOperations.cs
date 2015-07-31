namespace MathOperations
{
    using System;

    using DisplayExecutionTime;

    public class MathOperations
    {
        public static void CalculateSquareRoot()
        {
            Console.Write("Square root of float:   ");
            DisplayExecutionTime.Run(() =>
            {
                float result = 1000000f;
                for (int i = 0; i < 100000; i++)
                {
                    result = (float)Math.Sqrt(result);
                }
            });

            Console.Write("Square root of double:  ");
            DisplayExecutionTime.Run(() =>
            {
                double result = 1000000.0;
                for (int i = 0; i < 100000; i++)
                {
                    result = Math.Sqrt(result);
                }
            });

            Console.Write("Square root of decimal: ");
            DisplayExecutionTime.Run(() =>
            {
                decimal result = 1000000m;
                for (int i = 0; i < 100000; i++)
                {
                    result = (decimal)Math.Sqrt((double)result);
                }
            });
        }

        public static void CalculateNaturalLogarithm()
        {
            Console.Write("Natural logarithm of float:   ");
            DisplayExecutionTime.Run(() =>
            {
                float result = 1000000f;
                for (int i = 0; i < 100000; i++)
                {
                    result = (float)Math.Log(result, Math.E);
                }
            });

            Console.Write("Natural logarithm of double:  ");
            DisplayExecutionTime.Run(() =>
            {
                double result = 1000000.0;
                for (int i = 0; i < 100000; i++)
                {
                    result = Math.Log(result, Math.E);
                }
            });

            Console.Write("Natural logarithm of decimal: ");
            DisplayExecutionTime.Run(() =>
            {
                decimal result = 1000000m;
                for (int i = 0; i < 100000; i++)
                {
                    ////System.OverflowException()
                    ////result = (decimal)Math.Log((double)result, Math.E);
                }
            });
        }

        public static void CalculateSinus()
        {
            Console.Write("Sinus of float:   ");
            DisplayExecutionTime.Run(() =>
            {
                float result = 1000000f;
                for (int i = 0; i < 100000; i++)
                {
                    result = (float)Math.Sin(result);
                }
            });

            Console.Write("Sinus of double:  ");
            DisplayExecutionTime.Run(() =>
            {
                double result = 1000000.0;
                for (int i = 0; i < 100000; i++)
                {
                    result = Math.Sin(result);
                }
            });

            Console.Write("Sinus of decimal: ");
            DisplayExecutionTime.Run(() =>
            {
                decimal result = 1000000m;
                for (int i = 0; i < 100000; i++)
                {
                    result = (decimal)Math.Sin((double)result);
                }
            });
        }

        public static void Main()
        {
            CalculateSquareRoot();
            CalculateNaturalLogarithm();
            CalculateSinus();
        }
    }
}