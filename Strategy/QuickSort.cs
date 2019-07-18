using System;
using System.Collections.Generic;

namespace Strategy
{
    internal class QuickSort : ISort
    {
        public void Sort(IList<int> numbers)
        {
            Console.WriteLine("Quick sorting");
        }
    }
}