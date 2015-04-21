using System;

namespace TRES4Numbers
{
    class TRES4
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());

            string[] a = { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

            string result = "";
            if (number == 0)
            {
                Console.WriteLine("LON+");
            }
            while (number != 0)
            {
                result = a[(int)(number % 9)] + result;
                number /= 9;
            }
            Console.WriteLine(result);
        }
    }
}
