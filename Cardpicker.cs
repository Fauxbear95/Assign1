using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class Cardpicker
    {
        static Random random = new Random(1);
        //Value allocates a numeric equivalent to each card value
        enum Value
        {
            Ace = 1, 
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
            King = 13
        }
        //Suit allocates a numeric equivalent to each suit type 
        enum Suit
        {
            Clubs = 1, 
            Spades = 2, 
            Hearts = 3, 
            Diamonds = 4
        }

        private static Value RandomValue()
        {
            return (Value)Enum.GetValues(typeof(Value)).GetValue(random.Next(1, 13));
        }

        private static Suit RandomSuit()
        {
            return (Suit)Enum.GetValues(typeof(Suit)).GetValue(random.Next(1, 4));
        }

        public static string[] PickSomeCards(int numCards)
        {

            string[] cards = new string[numCards];
            for (int i = 0; i < numCards; i++)
            {
                Value value = RandomValue();
                Suit suit = RandomSuit();

                cards[i] = $"{value} of {suit}";
            }
            return cards;
        }
    }
}
