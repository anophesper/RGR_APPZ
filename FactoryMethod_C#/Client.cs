﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_C_
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreatorA.");
            ClientCode(new ConcreteCreatorA());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreatorB.");
            ClientCode(new ConcreteCreatorB());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n"
                + creator.SomeOperation());
        }
    }
}
