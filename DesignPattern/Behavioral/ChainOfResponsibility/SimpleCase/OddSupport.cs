using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.ChainOfResponsibility.SimpleCase
{
    public class OddSupport : SupportHandler
    {
        public OddSupport(string name) : base(name)
        {

        }

        protected override bool Resolve(Request trouble)
        {
            if (trouble.Number % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
