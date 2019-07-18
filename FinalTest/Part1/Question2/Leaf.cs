using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question2
{
    public class Leaf : Component
    {
        public Leaf(int value) : base(value)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override int Sum()
        {
            return this.value;
        }
    }
}
