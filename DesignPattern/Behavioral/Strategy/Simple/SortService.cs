using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy.Simple
{
    public class SortService
    {
        private ISortStrategy _sortStrategy;

        public SortService()
        {
            // Default Strategy as a quicksort
            _sortStrategy = new QuickSortStrategy();
        }

        public void SetStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void ExecuteSort(List<int> data)
        {
            _sortStrategy.Sort(data);
        }
    }
}
