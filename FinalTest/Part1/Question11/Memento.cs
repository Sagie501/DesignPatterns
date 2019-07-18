using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question11
{
    class Memento
    {
        GameStatus savedState;
        public Memento()
        {
        }

        public void Save(GameStatus state)
        {
            savedState = new GameStatus(state);
        }

        public GameStatus Load()
        {
            return new GameStatus(savedState);
        }
    }
}
