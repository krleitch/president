using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Move
    {
        private int value { get; }
        private int count { get; }

        public Move (int value, int count)
        {
            this.value = value;
            this.count = count;
        }
    }
}
