using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        ulong width = ulong.Parse(Console.ReadLine());
        ulong n0 = ulong.Parse(Console.ReadLine());
        ulong n1 = ulong.Parse(Console.ReadLine());
        ulong n2 = ulong.Parse(Console.ReadLine());
        ulong n3 = ulong.Parse(Console.ReadLine());
        ulong n4 = ulong.Parse(Console.ReadLine());
        ulong n5 = ulong.Parse(Console.ReadLine());
        ulong n6 = ulong.Parse(Console.ReadLine());
        ulong n7 = ulong.Parse(Console.ReadLine());


        while (true)
        {
            string command = Console.ReadLine();

            if (command == "stop")
            {
                break;
            }
            ulong row = 0;
            ulong col = 0;
            switch (command)
            {
                #region right
                case "right":
                    row = ulong.Parse(Console.ReadLine()); // 0
                    col = ulong.Parse(Console.ReadLine()); // 4

                    if (col < 0)
                    {
                        col = 0;
                    }
                    if (col >= width + 1)
                    {
                        col = width - 1;
                    }
                    // vzimam kolko bita ima
                    ulong bitCount = 0;
                    ulong a = 1;
                    if (row == 0)
                    {
                        for (ulong i = 0; i < width - col; i++) // ot 8 - 4 = 4 puti obikalq
                        {
                            ulong mask = a << i;
                            ulong nAndMask = n0 & mask;
                            ulong bit = nAndMask >> i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }
                        for (ulong i = 0; i < width - col; i++)
                        {
                            ulong mask = ~(1 << i);
                            n0 = n0 & mask;
                        }
                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << i;
                            n0 = n0 | mask;
                        }
                    }

                    if (row == 1)
                    {
                        for (ulong i = 0; i < width - col; i++) // ot 8 - 4 = 4 puti obikalq
                        {
                            ulong mask = 1 << i;
                            ulong nAndMask = n1 & mask;
                            ulong bit = nAndMask >> i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }
                        for (ulong i = 0; i < width - col; i++)
                        {
                            ulong mask = ~(1 << i);
                            n1 = n1 & mask;
                        }
                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << i;
                            n1 = n1 | mask;
                        }
                    }

                    if (row == 2)
                    {
                        for (ulong i = 0; i < width - col; i++) // ot 8 - 4 = 4 puti obikalq
                        {
                            ulong mask = 1 << i;
                            ulong nAndMask = n2 & mask;
                            ulong bit = nAndMask >> i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }
                        for (ulong i = 0; i < width - col; i++)
                        {
                            ulong mask = ~(1 << i);
                            n2 = n2 & mask;
                        }
                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << i;
                            n2 = n2 | mask;
                        }
                    }

                    if (row == 3)
                    {
                        for (ulong i = 0; i < width - col; i++) // ot 8 - 4 = 4 puti obikalq
                        {
                            ulong mask = 1 << i;
                            ulong nAndMask = n3 & mask;
                            ulong bit = nAndMask >> i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }
                        for (ulong i = 0; i < width - col; i++)
                        {
                            ulong mask = ~(1 << i);
                            n3 = n3 & mask;
                        }
                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << i;
                            n3 = n3 | mask;
                        }
                    }

                    if (row == 4)
                    {
                        for (ulong i = 0; i < width - col; i++) // ot 8 - 4 = 4 puti obikalq
                        {
                            ulong mask = 1 << i;
                            ulong nAndMask = n4 & mask;
                            ulong bit = nAndMask >> i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }
                        for (ulong i = 0; i < width - col; i++)
                        {
                            ulong mask = ~(1 << i);
                            n4 = n4 & mask;
                        }
                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << i;
                            n4 = n4 | mask;
                        }
                    }

                    if (row == 5)
                    {
                        for (ulong i = 0; i < width - col; i++) // ot 8 - 4 = 4 puti obikalq
                        {
                            ulong mask = 1 << i;
                            ulong nAndMask = n5 & mask;
                            ulong bit = nAndMask >> i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }
                        for (ulong i = 0; i < width - col; i++)
                        {
                            ulong mask = ~(1 << i);
                            n5 = n5 & mask;
                        }
                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << i;
                            n5 = n5 | mask;
                        }
                    }

                    if (row == 6)
                    {
                        for (ulong i = 0; i < width - col; i++) // ot 8 - 4 = 4 puti obikalq
                        {
                            ulong mask = 1 << i;
                            ulong nAndMask = n6 & mask;
                            ulong bit = nAndMask >> i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }
                        for (ulong i = 0; i < width - col; i++)
                        {
                            ulong mask = ~(1 << i);
                            n6 = n6 & mask;
                        }
                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << i;
                            n6 = n6 | mask;
                        }
                    }

                    if (row == 7)
                    {
                        for (ulong i = 0; i < width - col; i++) // ot 8 - 4 = 4 puti obikalq
                        {
                            ulong mask = 1 << i;
                            ulong nAndMask = n7 & mask;
                            ulong bit = nAndMask >> i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }
                        for (ulong i = 0; i < width - col; i++)
                        {
                            ulong mask = ~(1 << i);
                            n7 = n7 & mask;
                        }
                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << i;
                            n7 = n7 | mask;
                        }
                    }


                    break;
                #endregion
                #region left

                case "left":
                    row = ulong.Parse(Console.ReadLine());
                    col = ulong.Parse(Console.ReadLine());

                    if (col < 0)
                    {
                        col = 0;
                    }
                    if (col >= width + 1)
                    {
                        col = width - 1;
                    }
                    // vzimam kolko bita ima
                    bitCount = 0;

                    if (row == 0)
                    {
                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            ulong nAndMask = n0 & mask;
                            ulong bit = nAndMask >> width - 1 - i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }

                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = ~(1 << width - 1 - i);
                            n0 = n0 & mask;
                        }

                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            n0 = n0 | mask;
                        }
                    }

                    if (row == 1)
                    {
                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            ulong nAndMask = n1 & mask;
                            ulong bit = nAndMask >> width - 1 - i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }

                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = ~(1 << width - 1 - i);
                            n1 = n1 & mask;
                        }

                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            n1 = n1 | mask;
                        }
                    }

                    if (row == 2)
                    {
                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            ulong nAndMask = n2 & mask;
                            ulong bit = nAndMask >> width - 1 - i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }

                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = ~(1 << width - 1 - i);
                            n2 = n2 & mask;
                        }

                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            n2 = n2 | mask;
                        }
                    }

                    if (row == 3)
                    {
                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            ulong nAndMask = n3 & mask;
                            ulong bit = nAndMask >> width - 1 - i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }

                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = ~(1 << width - 1 - i);
                            n3 = n3 & mask;
                        }

                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            n3 = n3 | mask;
                        }
                    }

                    if (row == 4)
                    {
                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            ulong nAndMask = n4 & mask;
                            ulong bit = nAndMask >> width - 1 - i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }

                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = ~(1 << width - 1 - i);
                            n4 = n4 & mask;
                        }

                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            n4 = n4 | mask;
                        }
                    }

                    if (row == 5)
                    {
                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            ulong nAndMask = n5 & mask;
                            ulong bit = nAndMask >> width - 1 - i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }

                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = ~(1 << width - 1 - i);
                            n5 = n5 & mask;
                        }

                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            n5 = n5 | mask;
                        }
                    }

                    if (row == 6)
                    {
                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            ulong nAndMask = n6 & mask;
                            ulong bit = nAndMask >> width - 1 - i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }

                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = ~(1 << width - 1 - i);
                            n6 = n6 & mask;
                        }

                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            n6 = n6 | mask;
                        }
                    }

                    if (row == 7)
                    {
                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            ulong nAndMask = n7 & mask;
                            ulong bit = nAndMask >> width - 1 - i;
                            if (bit == 1)
                            {
                                bitCount++;
                            }
                        }

                        for (ulong i = 0; i < col + 1; i++)
                        {
                            ulong mask = ~(1 << width - 1 - i);
                            n7 = n7 & mask;
                        }

                        for (ulong i = 0; i < bitCount; i++)
                        {
                            ulong mask = 1 << width - 1 - i;
                            n7 = n7 | mask;
                        }
                    }

                    
                    break;

                #endregion
                case "reset":
                    // vzimam kolko bita ima
                    bitCount = 0;

                    for (ulong i = 0; i < width; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        ulong nAndMask = n0 & mask;
                        ulong bit = nAndMask >> width - 1 - i;
                        if (bit == 1)
                        {
                            bitCount++;
                        }
                    }
                        
                    n0 = 0;

                    for (ulong i = 0; i < bitCount; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        n0 = n0 | mask;
                    }
                    bitCount = 0;
                    for (ulong i = 0; i < width; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        ulong nAndMask = n1 & mask;
                        ulong bit = nAndMask >> width - 1 - i;
                        if (bit == 1)
                        {
                            bitCount++;
                        }
                    }
                        
                    n1 = 0;

                    for (ulong i = 0; i < bitCount; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        n1 = n1 | mask;
                    }
                    bitCount = 0;
                    for (ulong i = 0; i < width; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        ulong nAndMask = n2 & mask;
                        ulong bit = nAndMask >> width - 1 - i;
                        if (bit == 1)
                        {
                            bitCount++;
                        }
                    }
                        
                    n2 = 0;

                    for (ulong i = 0; i < bitCount; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        n2 = n2 | mask;
                    }
                    bitCount = 0;
                    for (ulong i = 0; i < width; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        ulong nAndMask = n3 & mask;
                        ulong bit = nAndMask >> width - 1 - i;
                        if (bit == 1)
                        {
                            bitCount++;
                        }
                    }
                        
                    n3 = 0;

                    for (ulong i = 0; i < bitCount; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        n3 = n3 | mask;
                    }
                    bitCount = 0;
                    for (ulong i = 0; i < width; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        ulong nAndMask = n4 & mask;
                        ulong bit = nAndMask >> width - 1 - i;
                        if (bit == 1)
                        {
                            bitCount++;
                        }
                    }
                        
                    n4 = 0;

                    for (ulong i = 0; i < bitCount; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        n4 = n4 | mask;
                    }
                    bitCount = 0;
                    for (ulong i = 0; i < width; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        ulong nAndMask = n5 & mask;
                        ulong bit = nAndMask >> width - 1 - i;
                        if (bit == 1)
                        {
                            bitCount++;
                        }
                    }
                        
                    n5 = 0;

                    for (ulong i = 0; i < bitCount; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        n5 = n5 | mask;
                    }
                    bitCount = 0;
                    for (int i = 0; i < width; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        ulong nAndMask = n6 & mask;
                        ulong bit = nAndMask >> width - 1 - i;
                        if (bit == 1)
                        {
                            bitCount++;
                        }
                    }
                        
                    n6 = 0;

                    for (ulong i = 0; i < bitCount; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        n6 = n6 | mask;
                    }
                    bitCount = 0;
                    for (ulong i = 0; i < width; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        ulong nAndMask = n7 & mask;
                        ulong bit = nAndMask >> width - 1 - i;
                        if (bit == 1)
                        {
                            bitCount++;
                        }
                    }
                        
                    n7 = 0;
                    for (ulong i = 0; i < bitCount; i++)
                    {
                        ulong mask = 1 << width - 1 - i;
                        n7 = n7 | mask;
                    }

                    break;
                default: break;
            }
        }

        ulong sum = n0 + n1 + n2 + n3 + n4 + n5 + n6 + n7;

        ulong linesCounter = 0;
        for (ulong i = 0; i < width; i++)
        {
            ulong zeroCounter = 0;

            ulong mask = 1 << i;
            ulong nAndMask = n0 & mask;
            ulong bit = nAndMask >> i;

            if (bit == 0)
            {
                zeroCounter++;
            }

            nAndMask = n1 & mask;
            bit = nAndMask >> i;

            if (bit == 0)
            {
                zeroCounter++;
            }

            nAndMask = n2 & mask;
            bit = nAndMask >> i;

            if (bit == 0)
            {
                zeroCounter++;
            }

            nAndMask = n3 & mask;
            bit = nAndMask >> i;

            if (bit == 0)
            {
                zeroCounter++;
            }

            nAndMask = n4 & mask;
            bit = nAndMask >> i;

            if (bit == 0)
            {
                zeroCounter++;
            }

            nAndMask = n5 & mask;
            bit = nAndMask >> i;

            if (bit == 0)
            {
                zeroCounter++;
            }

            nAndMask = n6 & mask;
            bit = nAndMask >> i;

            if (bit == 0)
            {
                zeroCounter++;
            }

            nAndMask = n7 & mask;
            bit = nAndMask >> i;

            if (bit == 0)
            {
                zeroCounter++;
            }

            if (zeroCounter == 8)
            {
                linesCounter++;
            }
        }
        ulong result = sum * linesCounter;
        Console.WriteLine(result);

    }
}