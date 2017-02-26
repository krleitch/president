using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Player
    {
        private List<Card> hand { get; }
        public string name;


        public abstract Move TurnStart();

        public Player()
        {
            hand = new List<Card>();
        }

        public void handAddCard (Card card)
        {
            hand.Add(card);
        }

        public void handSort()
        {
            hand.Sort();
        }

        public void handRemoveCard (Card card)
        {
            hand.Remove(card);
        }

        public bool handIsEmpty ()
        {
            return hand.Count() == 0;
        }
        public string handToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (Card card in hand)
            {
                stringBuilder.Append(card.ToString());
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }
    }
}
