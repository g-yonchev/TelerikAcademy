using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string one1 = ".#.";
        string one2 = "##.";
        string one3 = ".#.";
        string one4 = ".#.";
        string one5 = "###";

        string zero1 = "###";
        string zero2 = "#.#";
        string zero3 = "#.#";
        string zero4 = "#.#";
        string zero5 = "###";

        for (int row = 1; row <= 5 ; row++)
	    {
		    for (int col = 15; col >= 0; col--)
			{   
                int mask = 1 << col;
                int nAndMask = n & mask;
                int bit = nAndMask >> col;

                // bit = 0
                if (col == 0)
                {
                    if (bit == 0 && row == 1)
                    {
                        Console.Write(zero1);
                    }
                    else if (bit == 0 && row == 2)
                    {
                        Console.Write(zero2);
                    }
                    else if (bit == 0 && row == 3)
                    {
                        Console.Write(zero3);
                    }
                    else if (bit == 0 && row == 4)
                    {
                        Console.Write(zero4);
                    }
                    else if (bit == 0 && row == 5)
                    {
                        Console.Write(zero5);
                    }

                    // bit = 1
                    else if (bit == 1 && row == 1)
                    {
                        Console.Write(one1);
                    }
                    else if (bit == 1 && row == 2)
                    {
                        Console.Write(one2);
                    }
                    else if (bit == 1 && row == 3)
                    {
                        Console.Write(one3);
                    }
                    else if (bit == 1 && row == 4)
                    {
                        Console.Write(one4);
                    }
                    else if (bit == 1 && row == 5)
                    {
                        Console.Write(one5);
                    }
                }
                else
                {
                    if (bit == 0 && row == 1)
                    {
                        Console.Write(zero1 + ".");
                    }
                    else if (bit == 0 && row == 2)
                    {
                        Console.Write(zero2 + ".");
                    }
                    else if (bit == 0 && row == 3)
                    {
                        Console.Write(zero3 + ".");
                    }
                    else if (bit == 0 && row == 4)
                    {
                        Console.Write(zero4 + ".");
                    }
                    else if (bit == 0 && row == 5)
                    {
                        Console.Write(zero5 + ".");
                    }

                    // bit = 1
                    else if (bit == 1 && row == 1)
                    {
                        Console.Write(one1 + ".");
                    }
                    else if (bit == 1 && row == 2)
                    {
                        Console.Write(one2 + ".");
                    }
                    else if (bit == 1 && row == 3)
                    {
                        Console.Write(one3 + ".");
                    }
                    else if (bit == 1 && row == 4)
                    {
                        Console.Write(one4 + ".");
                    }
                    else if (bit == 1 && row == 5)
                    {
                        Console.Write(one5 + ".");
                    }
                }
                
			}
            Console.WriteLine();
		}
    }
}