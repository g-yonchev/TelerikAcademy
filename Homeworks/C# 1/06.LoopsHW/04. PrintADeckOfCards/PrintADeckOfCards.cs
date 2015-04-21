using System;

class PrintADeckOfCards
{
    static void Main()
    {
        /*  Problem 4. Print a Deck of 52 Cards

            Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
            The card faces should start from 2 to A.
            Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
            
            output

            2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
            3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
            …  
            K of spades, K of clubs, K of hearts, K of diamonds
            A of spades, A of clubs, A of hearts, A of diamonds
            
            Note: You may use the suit symbols instead of text.
         */

        Console.Title = "Print a Deck of 52 Cards";

        Console.WriteLine("Deck of 52 Cards");
        Console.WriteLine();

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                string card = Convert.ToString(i);
                char suits = '1';
                switch (i)
                {
                    case 11: card = "J"; break;
                    case 12: card = "Q"; break;
                    case 13: card = "K"; break;
                    case 14: card = "A"; break;
                }

                switch (j)
                {
                    case 1: suits = '\u2660'; break; // ♠
                    case 2: suits = '\u2665'; break; // ♥
                    case 3: suits = '\u2666'; break; // ♦
                    case 4: suits = '\u2663'; break; // ♣
                }
                if (j == 4)
                {
                    Console.Write("{0,2}{1}", card, suits);
                }
                else
                {
                    Console.Write("{0,2}{1}, ", card, suits);
                } 
            }
            Console.WriteLine();
        }

    }
}