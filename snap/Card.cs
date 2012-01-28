using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snap
{
    class Card
    {
        private Rank _rank;
        private Suit _suit;
        public Card(Rank rank, Suit suit)
        {
            _rank = rank;
            _suit = suit;
        }
        public string GetValue()
        {
            return _rank + " of " + _suit;
        }
    }
}
