using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balking_C_
{
    public class Balking
    {
        private bool isInitialized = false;
        private readonly object lockObj = new object();

        public void Initialize()
        {
            lock (lockObj)
            {
                if (isInitialized)
                    return; // Balking

                // Initialization code
                Console.WriteLine("Initializing...");

                isInitialized = true;
            }
        }
    }
}
