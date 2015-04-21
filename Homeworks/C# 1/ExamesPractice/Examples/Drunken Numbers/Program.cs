using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        long v = 0;
        long m = 0;

        for (int i = 0; i < N; i++)
        {
            long round = int.Parse(Console.ReadLine());

            round = Math.Abs(round);


            if (Convert.ToString(round).Length % 2 == 0)
            {
                long tempRound = round;
                for (int j = 0; j < Convert.ToString(round).Length / 2; j++)
                {
                    v += tempRound % 10;
                    tempRound /= 10;
                }

                for (int j = 0; j < Convert.ToString(round).Length / 2; j++)
                {
                    m += tempRound % 10;
                    tempRound /= 10;
                }
            }
            else if (Convert.ToString(round).Length % 2 == 1)
            {
                long tempRound = round;
                for (int j = 0; j < Convert.ToString(round).Length / 2; j++)
                {
                    v += tempRound % 10;
                    tempRound /= 10;
                }
                long middleNumber = tempRound % 10;
                v += middleNumber;
                m += middleNumber;
                tempRound /= 10;

                for (int j = 0; j < Convert.ToString(round).Length / 2; j++)
                {
                    m += tempRound % 10;
                    tempRound /= 10;
                }
            }
        }

        if (v > m)
        {
            Console.WriteLine("V {0}", v - m);
        }

        if (m > v)
        {
            Console.WriteLine("M {0}", m - v);
        }

        if (v == m)
        {
            Console.WriteLine("No {0}", v + m);
        }
    }
}