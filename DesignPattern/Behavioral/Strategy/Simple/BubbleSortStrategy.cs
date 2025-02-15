using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy.Simple
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            for(int i = 0; i < list.Count - 1; i++)
            {
                for(int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = list[j];
                    }
                }
            }
        }
    }
}
