using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_C_
{
    public class FlyweightFactory
    {
        private List<Tuple<IFlyweight, string>> flyweights = new List<Tuple<IFlyweight, string>>();

        public FlyweightFactory(params string[] args)
        {
            foreach (var state in args)
            {
                flyweights.Add(new Tuple<IFlyweight, string>(new ConcreteFlyweight(state), state));
            }
        }

        public IFlyweight GetFlyweight(string sharedState)
        {
            var flyweight = flyweights.Find(t => t.Item2 == sharedState);

            if (flyweight == null)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                var newFlyweight = new ConcreteFlyweight(sharedState);
                flyweights.Add(new Tuple<IFlyweight, string>(newFlyweight, sharedState));
                return newFlyweight;
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
                return flyweight.Item1;
            }
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"FlyweightFactory: I have {flyweights.Count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}
