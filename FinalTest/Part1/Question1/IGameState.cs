using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question1
{
    public interface IGameState
    {
        void NextState(ShipStatusBase shipStatusBase);
    }
}
