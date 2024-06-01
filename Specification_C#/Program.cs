using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            var spec = new AgeSpecification(18, 30);

            var person1 = new Person("John Doe", 25);
            var person2 = new Person("Jane Doe", 35);

            Console.WriteLine($"Person {person1.Name} is satisfied by specification: {spec.IsSatisfiedBy(person1)}");
            Console.WriteLine($"Person {person2.Name} is satisfied by specification: {spec.IsSatisfiedBy(person2)}");
            Console.ReadLine();
        }
    }
}
