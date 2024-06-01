using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Balking_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            var balking = new Balking();

            // Creating threads to test balking pattern
            Thread thread1 = new Thread(balking.Initialize);
            Thread thread2 = new Thread(balking.Initialize);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
            Console.ReadLine();
        }
    }
}
