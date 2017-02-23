using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Card
    {
        public int value { get; set; }
        public Suit suit { get; set; }

        public Card(Suit suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public override string ToString () {
            return value.ToString() + " of " + suit.ToString();
        }
    }
}
