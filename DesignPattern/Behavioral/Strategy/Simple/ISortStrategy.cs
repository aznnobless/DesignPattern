using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy.Simple
{
    public interface ISortStrategy
    {
        public void Sort(List<int> list);
    }
}
