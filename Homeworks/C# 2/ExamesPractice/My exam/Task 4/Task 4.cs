using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Task4
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var methods = new List<string>();

        string line = Console.ReadLine();

        for (int i = 0; i < n; i++)
        {

            if (line.Contains("static"))
            {
                string[] arr = line.Split(new char[] { ' ', '(' }, StringSplitOptions.RemoveEmptyEntries);
                string method = arr[2];
                Console.Write("{0} -> ", method);

                var list = new List<string>();

                do
                {
                    line = Console.ReadLine();
                    i++;

                    if (line.Contains("."))
                    {
                        int indexStart = line.IndexOf(".") + 1;

                        if (char.IsLetter(line[indexStart]))
                        {
                            int indexEnd = line.IndexOf("(", indexStart);
                            if (indexEnd != -1)
                            {
                                string m = line.Substring(indexStart, indexEnd - indexStart);
                                list.Add(m);
                            }
                        }
                    }


                } while (!line.Contains("static"));
                Console.Write("{0} -> ", list.Count);
                Console.Write(string.Join(", ", list));
                Console.WriteLine();
                continue;
            }

            line = Console.ReadLine();

        }
    }
}
