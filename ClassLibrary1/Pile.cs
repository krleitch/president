﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Pile
    {
        private List<Card> pile;   

        public Pile(int numDecks)
        {
            pile = new List<Card>();
            for (int i = 0; i < numDecks; i++)
            {
                Deck d = new Deck();
                foreach (Card c in d.cardList){
                    pile.Add(c);
                }
            }
            pile.Shuffle();
        }

        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (Card card in pile)
            {
                stringBuilder.Append(card.ToString());
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }   
    }
}
