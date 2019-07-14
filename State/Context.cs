using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        public ILightState State { get; set; }

        public Context()
        {
        }

        public void Init(ILightState state)
        {
            this.State = state;
        }

        public void PressedOn()
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");
            State.TurnOn();
        }

        public void PressedOff()
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");
            State.TurnOff();
        }

        public void FixIt()
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");
            State.Fix();
        }
    }
}
