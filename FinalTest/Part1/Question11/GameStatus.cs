using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question11
{
    class GameStatus
    {
        public int number, i, j;

        public GameStatus(int number, int i, int j)
        {
            this.number = number;
            this.i = i;
            this.j = j;
        }

        public GameStatus(GameStatus state) : this(state.number, state.i, state.j)
        {
        }
    }
}
