using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question2
{
    public abstract class Component
    {
        protected int value;

        protected Component(int value)
        {
            this.value = value;
        }

        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();

        public abstract int Sum();
        public static bool IsEven(Component component)
        {
            if (component.value % 2 != 0)
                return false;
            IList<Component> childs = component.GetChilds();
            if (childs != null)
            {
                foreach (Component c in childs)
                {
                    if (!IsEven(c))
                        return false;
                }
            }
            return true;
        }
    }
}
