using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bunny_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cages = new List<int>();

            while (true)
            {
                string bunnies = Console.ReadLine();
                if (bunnies != "END")
                {
                    byte numberOfBunnies = byte.Parse(bunnies);
                    cages.Add(numberOfBunnies);
                }
                else
                {
                    break;
                }
            }

            int index = 1; // nomer na procesa zapochva ot edno i vseki put go uvelichavame s edno
            while (true)
            {
                int s = cages.Take(index).Sum(); // sumata, vseki put q proverqvame dali e...

                if (s > cages.Count)
                {
                    break;
                }

                BigInteger sum = 0;
                BigInteger product = 1;

                for (int i = index; i < s + index; i++) // 3 iterations. startint from 2nd element
                {
                    sum += cages[i];
                    product *= cages[i];
                }

                StringBuilder builder = new StringBuilder();

                builder.Append(sum);
                builder.Append(product);
                for (int i = index + s; i < cages.Count; i++)
                {
                    builder.Append(cages[i]);
                }
                
                cages.Clear();

                for (int i = 0; i < builder.Length; i++)
                {
                    if (builder[i] != '0' && builder[i] != '1')
                    {
                        cages.Add(builder[i] -'0');
                    }
                }

                index++;
            }

            Console.WriteLine(string.Join(" ", cages.ToArray()));

        }
    }
}
