using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Card : IComparable
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
        public override bool Equals(Object obj)
        {
            return ((obj != null) && (obj is Card) && (value == ((Card)obj).value) && (suit == ((Card)obj).suit));
        }
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            return value.CompareTo(((Card)obj).value);
        }
    }
}
