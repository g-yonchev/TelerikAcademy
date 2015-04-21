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
        int[] path = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(c => int.Parse(c))
            .ToArray();

        BigInteger MollyFwolers = 0;
        BigInteger DollyFwolers = 0;

        int MollyInex = 0;
        int DollyIndex = path.Length - 1;
        while (true)
        {
            MollyFwolers += (BigInteger)path[MollyInex];
            DollyFwolers += (BigInteger)path[DollyIndex];

            int MollyJumps = path[MollyInex];
            int DollyJumps = path[DollyIndex];

            path[MollyInex] = 0;
            path[DollyIndex] = 0;

            DollyIndex = DollyIndex + (int)MollyJumps;
            DollyIndex = DollyIndex - (int)DollyJumps;


        }

    }
}

