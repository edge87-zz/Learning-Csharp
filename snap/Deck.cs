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
            foreach (snap.Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(snap.Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Card c = new Card(rank, suit);
                    theCards.Add(c);
                }
            }
        }
    }

}
