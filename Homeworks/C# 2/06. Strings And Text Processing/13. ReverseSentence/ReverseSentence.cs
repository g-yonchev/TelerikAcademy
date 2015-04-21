namespace ReverseSentence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++ not PHP and not Delphi!";

            char sign = text[text.Length - 1];
            text = text.Remove(text.Length - 1, 1);
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            Console.WriteLine("Result: {0}{1}\n", string.Join(" ", words), sign);
        }
    }
}
