using System;
using System.Collections.Generic;

namespace Strategy
{
    internal class MergeSort : ISort
    {
        public void Sort(IList<int> numbers)
        {
            Console.WriteLine("Merge sorting");
        }
    }
}