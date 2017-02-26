using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{



    public class DiscardPile
    {
        private List<Move> pile;
        private bool burn;
        private Move current;

        public DiscardPile()
        {
            pile = new List<Move>();
            burn = false;
            current = null;
        }

        //Accessors

        // Pushes a Move onto the discard pile, returns true if success
        public bool push(Move move)
        {
            // Initial
            if (pile.Count == 0)
            {
                pile.Add(move);
                return true;
            }

            current = pile[pile.Count - 1];

            // General case
            if (burn)
                return pushBurn(move);
            else
                return pushGeneral(move);
        }

        private bool pushGeneral(Move move)
        {
            if (move.value >= current.value && move.count == current.count)
            {
                if (move.value == current.value)
                    burn = true;
                pile.Add(move);
                return true;
            }
            else
                return false;
        }

        private bool pushBurn(Move move)
        {
            if (move.value == current.value && move.count == current.count)
            {
                pile.Add(move);
                return true;
            }
            else
                return false;
        }


        // Can change return to something useful
        public bool clear()
        {
            pile = new List<Move>();
            return true;
        }

        public Move pileTop()
        {
            return pile[pile.Count - 1];
        }


    }

}
