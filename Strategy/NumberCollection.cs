using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class NumberCollection
    {
        protected IList<int> numbers;
        protected ISort sorter;

        private MergeSort mergeSortInstance;
        private QuickSort quickSortInstance;
        public NumberCollection()
        {
            this.numbers = new List<int>();
            this.mergeSortInstance = new MergeSort();
            this.quickSortInstance = new QuickSort();
            this.sorter = mergeSortInstance;
        }

        public void Add(int number)
        {
            this.numbers.Add(number);
            if (this.numbers.Count() > 1000)
            {
                this.sorter = quickSortInstance;
            }
            else
            {
                this.sorter = mergeSortInstance;
            }
        }

        public void Remove(int number)
        {
            this.numbers.Remove(number);
            if (this.numbers.Count() > 1000)
            {
                this.sorter = quickSortInstance;
            }
            else
            {
                this.sorter = mergeSortInstance;
            }
        }

        public void Sort()
        {
            this.sorter.Sort(this.numbers);
        }
    }
}
