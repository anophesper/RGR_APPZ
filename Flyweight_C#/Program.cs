using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_C_
{
    class Program
    {
        static void AddCarToPoliceDatabase(FlyweightFactory factory, string plates, string owner, string brand, string model, string color)
        {
            Console.WriteLine("\nClient: Adding a car to database.");

            var flyweight = factory.GetFlyweight($"{brand}_{model}_{color}");

            flyweight.Operation($"{plates}_{owner}");
        }

        static void Main(string[] args)
        {
            var factory = new FlyweightFactory("BMW_M5_black", "BMW_X6_red", "Mercedes_Benz_C300_black", "BMW_M5_red", "BMW_X1_white");

            factory.ListFlyweights();

            AddCarToPoliceDatabase(factory, "CL234IR", "James Doe", "BMW", "M5", "red");
            AddCarToPoliceDatabase(factory, "CL234IR", "James Doe", "BMW", "X1", "white");

            factory.ListFlyweights();
            Console.ReadLine();
        }
    }
}
