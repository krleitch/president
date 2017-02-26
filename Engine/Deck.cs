using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Deck
    {
        public List<Card> cardList{get;set;}

        public Deck()
        {
            cardList = new List<Card>();
            Suit[] suits = { Suit.Spade, Suit.Diamond, Suit.Club, Suit.Heart };
            foreach (Suit suit in suits)
            {
                for (int i = 1; i <= 13 ;i++){
                    cardList.Add(new Card(suit, i));
                }
            }
            cardList.Add(new Card(Suit.Joker, 14));
        }

        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (Card card in cardList)
            {
                stringBuilder.Append(card.ToString());
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }   
    }

}
