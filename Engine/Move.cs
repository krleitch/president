using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //
    // A way to keep track of the card and the amount
    //

    public class Move
    {
        public int value { get; }
        public int count { get; }

        public Move (int value, int count)
        {
            this.value = value;
            this.count = count;
        }
    }
}
