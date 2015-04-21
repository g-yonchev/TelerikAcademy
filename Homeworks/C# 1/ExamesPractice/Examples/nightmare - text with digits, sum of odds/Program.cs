using System;

class Program
{
    static void Main()
    {

        string text = Console.ReadLine(); // t1t2t22t2t2t22t22 - na men mi trqbvat nechetnite simvoli kato pochvam ot nula da broq. i mi trqbvat samo cifri.
        int counter = 0;
        int oddCounter = 0;
        int sum = 0;

        // za vseki simvol ot input na konzolata (string text) napravi slednoto:

        // ulovkata tuka e che char i int ne sa edni i sushti i trqbva da konvertiram char v int.
        foreach (char symbol in text)
        {
            if (counter % 2 != 0) // t.e. vseki symbol koito e necheten.
            {
                if (Char.IsDigit(symbol)) // proverqva dali symbola e chislo. ako ne e. go propuska.
                {
                    string a = Convert.ToString(symbol);
                    int b = int.Parse(a);
                    oddCounter++; //  uvelichi broqcha na nechetnite.
                    sum += b; // pribavqsh kum sumata namereniq necheten digit.
                }
            }
            counter++;
        }

        Console.WriteLine("{0} {1}", oddCounter, sum);
    }
}