using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_C_
{
    public class ConcreteProductA : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProductA}";
        }
    }
}
