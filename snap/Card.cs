namespace snap
{
    class Card
    {
        // Variables of Rank and Suit type
        private Rank _rank;
        private Suit _suit;

        //Constructor for a card object
        public Card(Rank rank, Suit suit)
        {
            _rank = rank;
            _suit = suit;
        }

        // returns a string which says the value of the card
        public string GetValue()
        {
            return _rank + " of " + _suit;
        }
    }
}
