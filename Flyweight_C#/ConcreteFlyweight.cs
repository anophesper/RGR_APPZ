using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_C_
{
    public class ConcreteFlyweight : IFlyweight
    {
        private string _sharedState;

        public ConcreteFlyweight(string sharedState)
        {
            this._sharedState = sharedState;
        }

        public void Operation(string uniqueState)
        {
            Console.WriteLine($"ConcreteFlyweight: Displaying shared ({_sharedState}) and unique ({uniqueState}) state.");
        }
    }
}
