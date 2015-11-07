using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPoker
{
	enum CardType
	{
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Ten = 10,
		Jack = 11,
		Queen = 12,
		King = 13,
		Ace = 14,
	}

	enum CardSuit
	{
		Club = 0, // ♣
		Diamond = 1, // ♦
		Heart = 2, // ♥
		Spade = 3 // ♠
	}

	class Card
	{
		public Card(CardSuit suit, CardType type)
		{
			this.Suit = suit;
			this.Type = type;
		}

		public CardSuit Suit { get; }

		public CardType Type { get; }
	}

	static class HandStrengthValuation
	{
		private static readonly int[,] StartingHandRecommendationsSuited =
			{
				{ 3, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1 }, // A
                { 0, 3, 3, 3, 3, 2, 1, 1, 1, 1, 1, 1, 1 }, // K
                { 0, 0, 3, 3, 3, 2, 2, 0, 0, 0, 0, 0, 0 }, // Q
                { 0, 0, 0, 3, 3, 3, 2, 1, 0, 0, 0, 0, 0 }, // J
                { 0, 0, 0, 0, 3, 3, 2, 1, 0, 0, 0, 0, 0 }, // 10
                { 0, 0, 0, 0, 0, 3, 2, 1, 1, 0, 0, 0, 0 }, // 9
                { 0, 0, 0, 0, 0, 0, 3, 1, 1, 0, 0, 0, 0 }, // 8
                { 0, 0, 0, 0, 0, 0, 0, 3, 1, 1, 0, 0, 0 }, // 7
                { 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 }, // 6
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 }, // 5
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 }, // 4
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 }, // 3
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 } // 2
            };

		private static readonly int[,] StartingHandRecommendationsUnsuited =
			{
				{ 3, 3, 3, 3, 3, 1, 1, 1, 0, 0, 0, 0, 0 }, // A
                { 0, 3, 3, 3, 2, 1, 0, 0, 0, 0, 0, 0, 0 }, // K
                { 0, 0, 3, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0 }, // Q
                { 0, 0, 0, 3, 2, 1, 1, 0, 0, 0, 0, 0, 0 }, // J
                { 0, 0, 0, 0, 3, 1, 1, 0, 0, 0, 0, 0, 0 }, // 10
                { 0, 0, 0, 0, 0, 3, 1, 1, 0, 0, 0, 0, 0 }, // 9
                { 0, 0, 0, 0, 0, 0, 3, 1, 0, 0, 0, 0, 0 }, // 8
                { 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0 }, // 7
                { 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0 }, // 6
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0 }, // 5
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 }, // 4
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 }, // 3
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 } // 2
            };

		// http://www.rakebackpros.net/texas-holdem-starting-hands/
		public static CardValuationType PreFlop(Card firstCard, Card secondCard)
		{
			var valueTest = firstCard.Suit == secondCard.Suit
							? (firstCard.Type > secondCard.Type
								   ? StartingHandRecommendationsSuited[12 - ((int)firstCard.Type - 2), 12 - ((int)secondCard.Type - 2)]
								   : StartingHandRecommendationsSuited[12 - ((int)secondCard.Type - 2), 12 - ((int)firstCard.Type - 2)])
							: (firstCard.Type > secondCard.Type
								   ? StartingHandRecommendationsUnsuited[12 - ((int)firstCard.Type - 2), 12 - ((int)secondCard.Type - 2)]
								   : StartingHandRecommendationsUnsuited[12 - ((int)secondCard.Type - 2), 12 - ((int)firstCard.Type - 2)]);

			var valueOriginal = firstCard.Suit == secondCard.Suit
							? (firstCard.Type < secondCard.Type
								   ? StartingHandRecommendationsSuited[(int)firstCard.Type - 2, (int)secondCard.Type - 2]
								   : StartingHandRecommendationsSuited[(int)secondCard.Type - 2, (int)firstCard.Type - 2])
							: (firstCard.Type < secondCard.Type
								   ? StartingHandRecommendationsUnsuited[(int)firstCard.Type - 2, (int)secondCard.Type - 2]
								   : StartingHandRecommendationsUnsuited[(int)secondCard.Type - 2, (int)firstCard.Type - 2]);

			//switch (valueOriginal)
            switch (valueTest)
			{
				case 0:
					return CardValuationType.Unplayable;
				case 1:
					return CardValuationType.NotRecommended;
				case 2:
					return CardValuationType.Risky;
				case 3:
					return CardValuationType.Recommended;
				default:
					return CardValuationType.Unplayable;
			}
		}
	}

	class Program
	{
		static void Main()
		{
			// Test here
			var firstCard = new Card(CardSuit.Diamond, CardType.Ten);
			var secondCard = new Card(CardSuit.Club, CardType.King);
			var result = HandStrengthValuation.PreFlop(firstCard, secondCard);
			Console.WriteLine(result);
		}
	}

	enum CardValuationType
	{
		Unplayable = 0,
		NotRecommended = 1000,
		Risky = 2000,
		Recommended = 3000
	}

}
