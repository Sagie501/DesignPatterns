using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question2
{
    public class Composite : Component
    {
        IList<Component> childs = new List<Component>();

        public Composite(int value) : base(value)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override int Sum()
        {
            int sum = this.value;
            foreach(Component c in childs)
            {
                sum += c.Sum();
            }

            return sum;
        }
    }
}
