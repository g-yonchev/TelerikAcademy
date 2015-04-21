using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        ulong number = ulong.Parse(input);

        var list = new List<string>();

        for (int i = 0; i < 26; i++)
        {
            char letter = (char)('A' + i);
            list.Add(letter.ToString());
        }

        for (int i = 0; i < 26; i++)
        {
            string letter = "a";
            list.Add(letter + list[i]);
        }

        for (int i = 0; i < 26; i++)
        {
            string letter = "b";
            list.Add(letter + list[i]);
        }
        for (int i = 0; i < 26; i++)
        {
            string letter = "c";
            list.Add(letter + list[i]);
        }
        for (int i = 0; i < 26; i++)
        {
            string letter = "d";
            list.Add(letter + list[i]);
        }
        for (int i = 0; i < 26; i++)
        {
            string letter = "e";
            list.Add(letter + list[i]);
        }
        for (int i = 0; i < 26; i++)
        {
            string letter = "f";
            list.Add(letter + list[i]);
        }
        for (int i = 0; i < 26; i++)
        {
            string letter = "g";
            list.Add(letter + list[i]);
        }
        for (int i = 0; i < 26; i++)
        {
            string letter = "h";
            list.Add(letter + list[i]);
        }
        for (int i = 0; i < 26; i++)
        {
            string letter = "i";
            list.Add(letter + list[i]);
        }

        var arr = new List<int>();

        while (number > 0)
        {
            int n = (int)(number % 256);
            arr.Insert(0, n);
            number /= 256;
        }

        var result = new StringBuilder();

        for (int i = 0; i < arr.Count; i++)
        {
            result.Append(list[arr[i]]);
        }

        if (input == "0")
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine(result.ToString());            
        }

        
    }
}

