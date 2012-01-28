// Testing commit. 

using System;

namespace snap
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck d1 = new Deck();
            
            foreach (Card c in d1.GetDeck())
            {
                Console.WriteLine(c.GetValue() +" of "+ c.GetType());
            }
            
            Console.WriteLine();
            Console.Read();
        }
    }
}
