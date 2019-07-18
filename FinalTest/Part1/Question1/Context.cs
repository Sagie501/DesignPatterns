using System;

namespace FinalTest.Question1
{
    public class Context
    {
        public IGameState gameState { get; set; }
        public IShipState shipState { get; set; }

        public Context()
        {

        }

        public void Init(IGameState state)
        {
            this.gameState = state;
        }
    }
}