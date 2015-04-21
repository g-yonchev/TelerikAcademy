using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Two_Girls__One_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] path = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => BigInteger.Parse(x))
                .ToArray();

            BigInteger molly = 0;
            BigInteger dolly = 0;

            BigInteger positionMolly = 0;
            BigInteger positionDolly = path.Length - 1; // last index


            string winner = "";

            while (true)
            {
                BigInteger stepsMolly = path[(int)positionMolly];
                BigInteger stepsDolly = path[(int)positionDolly];

                if (path[(int)positionMolly] == 0 || path[(int)positionDolly] == 0)
                {
                    if (positionMolly != positionDolly)
                    {
                        molly += path[(int)positionMolly];
                        dolly += path[(int)positionDolly];
                    }
                    else
                    {
                        if (path[(int)positionMolly] % 2 == 0) // even
                        {
                            molly += path[(int)positionMolly] / 2;
                            dolly += path[(int)positionDolly] / 2;
                        }
                    }

                    if (path[(int)positionMolly] == 0 && path[(int)positionDolly] == 0)
                    {
                        winner = "Draw";
                    }
                    else if (path[(int)positionMolly] == 0)
                    {
                        winner = "Dolly";
                    }
                    else
                    {
                        winner = "Molly";
                    }
                    

                    break;
                }

                if (positionMolly != positionDolly)
                {
                    molly += path[(int)positionMolly];
                    dolly += path[(int)positionDolly];

                    stepsMolly = path[(int)positionMolly];
                    stepsDolly = path[(int)positionDolly];

                    path[(int)positionDolly] = 0;
                    path[(int)positionMolly] = 0;
                }
                else
                {
                    if (path[(int)positionMolly] % 2 == 0) // even
                    {
                        molly += path[(int)positionMolly] / 2;
                        dolly += path[(int)positionDolly] / 2;

                        stepsMolly = path[(int)positionMolly];
                        stepsDolly = path[(int)positionDolly];

                        path[(int)positionDolly] = 0;
                    }
                    else // odd
                    {
                        molly += path[(int)positionMolly] / 2;
                        dolly += path[(int)positionDolly] / 2;

                        stepsMolly = path[(int)positionMolly];
                        stepsDolly = path[(int)positionDolly];

                        path[(int)positionDolly] = 1;
                    }
                }

                positionMolly += stepsMolly;

                if (positionMolly >= path.Length)
                {
                    positionMolly %= path.Length;
                }

                positionDolly -= stepsDolly;

                if (positionDolly >= path.Length)
                {
                    positionDolly %= path.Length;
                }
            }

            Console.WriteLine(winner);
            Console.WriteLine(molly + " " + dolly);
        }
    }
}
