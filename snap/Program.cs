// Testing commit. 

using System;

namespace snap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an instance of a Deck, call it d1 - call the constructor (Deck();) 
            // this makes us 52 cards in an arraylist - a standard deck of cards
            Deck d1 = new Deck();
            
            // Iterate the cards in the deck - for each card in the whole deck
            foreach (Card c in d1.GetDeck())
            {
                Console.WriteLine(c.GetValue() +" of "+ c.GetType());
            }

            d1.ShuffleDeck();

            Console.WriteLine("Shuffled Array");

            foreach (Card c in d1.GetDeck())
            {
                Console.WriteLine(c.GetValue() + " of " + c.GetType());
            }

            
            Console.WriteLine(); // write a new line
            Console.Read();     //pause for input (Enter will do)
        }
    }
}
