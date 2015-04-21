using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        ulong[] path = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(c => ulong.Parse(c))
            .ToArray();

        BigInteger MollyFwolers = 0;
        BigInteger DollyFwolers = 0;

        bool Dolly = false;
        bool Molly = false;

        int MollyIndex = 0;
        int DollyIndex = path.Length - 1;
        while (true)
        {
            if (path[MollyIndex] == 0 || path[DollyIndex] == 0)
            {
                if (path[MollyIndex] == 0)
                {
                    Molly = true;
                }

                if (path[DollyIndex] == 0)
                {
                    Dolly = true;
                }
            }

            if (MollyIndex == DollyIndex)
            {
                if (path[MollyIndex] % 2 == 0)
                {
                    MollyFwolers += (BigInteger)(path[MollyIndex] / 2);
                    DollyFwolers += (BigInteger)(path[DollyIndex] / 2);
                }
                else
                {
                    MollyFwolers += (BigInteger)((path[MollyIndex] - 1) / 2);
                    DollyFwolers += (BigInteger)(path[DollyIndex] / 2);
                }
            }
            else
            {
                MollyFwolers += (BigInteger)path[MollyIndex];
                DollyFwolers += (BigInteger)path[DollyIndex];
            }

            if (Dolly || Molly)
            {
                break;
            }


            ulong MollyJumps = path[MollyIndex];
            ulong DollyJumps = path[DollyIndex];

            if (MollyIndex == DollyIndex)
            {
                if (path[MollyIndex] % 2 == 0)
                {
                    path[MollyIndex] = 0;
                }
                else
                {
                    path[MollyIndex] = 1;
                }

            }
            else
            {
                path[MollyIndex] = 0;
                path[DollyIndex] = 0;
            }



            MollyIndex = (MollyIndex + (int)MollyJumps) % path.Length;
            if ((DollyIndex - (int)DollyJumps) % path.Length >= 0)
            {
                DollyIndex = (DollyIndex - (int)DollyJumps) % path.Length;
            }
            else
            {
                DollyIndex = path.Length + ((DollyIndex - (int)DollyJumps) % path.Length);
            }


        }

        if (Dolly && Molly)
        {
            Console.WriteLine("Draw");
        }
        else
        {
            if (Dolly)
            {
                Console.WriteLine("Molly");
            }
            else
            {
                Console.WriteLine("Dolly");
            }
        }

        Console.WriteLine("{0} {1}", MollyFwolers, DollyFwolers);

    }
}

