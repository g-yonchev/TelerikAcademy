namespace DisplayExecutionTime
{
    using System;
    using System.Diagnostics;

    public class DisplayExecutionTime
    {
        public static void Run(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
