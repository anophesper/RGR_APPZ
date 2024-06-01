using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_C_
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T candidate);
    }
}
