using System;
using System.Collections.Generic;

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
				foreach (var card in CardPicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}
        }
    }

    public static class SubsequenceFinder
    {
        /// <summary>
        /// Determines whether a list of integers is a subsequence of another list of integers
        /// </summary>
        /// <param name="seq">The main sequence of integers.</param>
        /// <param name="subseq">The potential subsequence.</param>
        /// <returns>True if subseq is a subsequence of seq and false otherise.</returns>
        public static bool IsValidSubsequence(List<int> seq, List<int> subseq)
        {
            int seqId = 0;
            int subseqId = 0;

            while (seqId < seq.Count)
            {
                Console.Write($"({seq[seqId]}, {subseq[subseqId]})");
                if (seq[seqId] == subseq[subseqId])
                {
                    seqId++;
                    subseqId++;
                    if (subseqId == subseq.Count)
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine();
                    seqId -= (subseqId - 1);
                    subseqId = 0;
                }
            }
            return false;
        }
    }

    class CardPicker
    {
        static Random random = new Random(1);
        /// <summary>
        /// Picks a random (with replacement) number of cards.
        /// </summary>
        /// <param name="numCards">The number of cards to choose at random.</param>
        /// <returns>An array of strings where each string represents a card.</returns>
        public static string[] PickSomeCards(int numCards)
        {

            string[] cards = new string[numCards];
            for (int i = 0; i < numCards; i++)
            {
                cards[i] = RandomValue() + RandomSuit();
            }
            return cards;
        }
        /// <summary>
        /// Chooses a random value for a card (Ace, 2, 3, ... , Queen, King)
        /// </summary>
        /// <returns>A string that represents the value of a card</returns>
        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1)
            {
                return "Ace of ";
            }
            else if (value == 2)
            {
                return "2 of ";
            }
            else if (value == 3)
            {
                return "3 of ";
            }
            else if (value == 4)
            {
                return "4 of ";
            }
            else if (value == 5)
            {
                return "5 of ";
            }
            else if (value == 6)
            {
                return "6 of ";
            }
            else if (value == 7)
            {
                return "7 of ";
            }
            else if (value == 8)
            {
                return "8 of ";
            }
            else if (value == 9)
            {
                return "9 of ";
            }
            else if (value == 10)
            {
                return "10 of ";
            }
            else if (value == 11)
            {
                return "Jack of ";
            }
            else if (value == 12)
            {
                return "Queen of ";
            }
            else if (value == 13)
            {
                return "King of ";
            }

            throw new NotImplementedException();
        }
        /// <summary>
        /// Chooses a random suit for a card (Clubs, Diamonds, Hearts, Spades)
        /// </summary>
        /// <returns>A string that represents the suit of a card.</returns>
        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1)
            {
                return "Hearts";
            }
            else if (value == 2)
            {
                return "Diamonds";
            }
            else if (value == 3)
            {
                return "Clubs";
            }
            else if (value == 4)
            {
                return "Spades";
            }
            throw new NotImplementedException();
        }
    }
}
