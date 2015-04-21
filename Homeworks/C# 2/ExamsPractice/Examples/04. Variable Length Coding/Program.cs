using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_Length_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] a = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => byte.Parse(x))
                .ToArray();





            StringBuilder builder = new StringBuilder();
            builder.Append('0');
            for (int i = 0; i < a.Length; i++)
            {
                string number = Convert.ToString(a[i], 2);

                // !!!!!!!!!
                if (number.Length == 7)
                {
                    builder.Append("0");
                }
                builder.Append(number);
            }

            string b = builder.ToString();

            int lastOne = b.LastIndexOf('1'); //12


            // ????? dava mi nqkav exeption
            // builder.Remove(lastOne + 1, builder.Length - lastOne);

            int count = int.Parse(Console.ReadLine());

            string[] table = new string[count];

            for (int i = 0; i < count; i++)
            {
                table[i] = Console.ReadLine();
                int howManyOnes = int.Parse(table[i].Substring(1, table[i].Length - 1));

                while (true)
                {
                    string findingString = "0" + new string('1', howManyOnes) + "0";
                    int whereIndex = b.IndexOf(findingString); // 21

                    b.Insert();
                    b.Remove(whereIndex + 1, howManyOnes);

                }
            }



            // int frequency = int.Parse(cell[i].Substring(1, cell[i].Length - 1)); // take how many '1'



        }

        static void Cells(string cell)
        {

        }
    }
}
