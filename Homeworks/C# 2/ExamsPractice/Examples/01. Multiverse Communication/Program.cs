using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var text = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        var input = Console.ReadLine();
        long decimalRepresentation = 0;
        for (int i = 0; i < input.Length; i += 3)
        {
            var digitIn13 = input.Substring(i, 3);
            var decimalValue = text.IndexOf(digitIn13);
            decimalRepresentation *= 13;
            decimalRepresentation += decimalValue;
        }
        Console.WriteLine(decimalRepresentation);
    }
}