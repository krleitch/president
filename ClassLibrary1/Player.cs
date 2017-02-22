using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Player
    {
        List<Card> hand;

        public abstract void play();
    }
}
