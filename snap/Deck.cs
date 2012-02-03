using System;
using System.Collections;

namespace snap
{
    class Deck
    {
        private ArrayList theCards;
        
        public Deck()
        {
            theCards = new ArrayList();

            // foreach loop says (for a Suit object (called) "suit" 
            // iterate through all possible values in that type (Suit) 
            foreach (snap.Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(snap.Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Card c = new Card(rank, suit);
                    theCards.Add(c);
                }
            }
        }
        // return an arraylist which contains all the cards, that way we can use the 
        // System.Collections methods to manipulate this (and add/remove cards) from the deck
        public ArrayList GetDeck()
        {
            return theCards;
        }

        public void ShuffleDeck()
        {
            theCards.shuffle();
        }
    }

}
