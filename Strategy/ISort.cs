using System.Collections.Generic;

namespace Strategy
{
    public interface ISort
    {
        void Sort(IList<int> numbers);
    }
}