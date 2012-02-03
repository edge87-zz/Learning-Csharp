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
            //Get a random amount of cards to swap above 1000 (but below 2000)
            Random rannumb = new Random();

            int shufloop = rannumb.Next(1000, 2001);

            for (int i = 0; i < shufloop; i++)
            {
                //pick first slot. 0 to 52 doesn't include 52 so it should give me a number between 0 and 51 valid ranges in the array
                int slot1 = rannumb.Next(0,52);

                //pick second slot
                int slot2 = rannumb.Next(0, 52); 

                //swap them
                SwapSpot(slot1, slot2);
            }


        }

        private void SwapSpot(int pos1, int pos2)
        {
            //Validate pos1 and pos2 are valid spots in the array where the cards live

            Card tempCard = (Card)theCards[pos2];

            theCards[pos2] = theCards[pos1];
            theCards[pos1] = tempCard;


        }

        public void NewDeck()
        {
            //Destroy current Deck
            theCards.Clear();

            foreach (snap.Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (snap.Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Card c = new Card(rank, suit);
                    theCards.Add(c);
                }
            }
        }
    }

}
