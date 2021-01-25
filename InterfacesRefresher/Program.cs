using System;
using System.Collections.Generic;

namespace InterfacesRefresher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Please the creation of objects (new) to an absolute minimum
            // And please keep it to restricted to the Program Class as much as possible
            var notifications = new List<INotification>
            {
                new Sms(),
                new Mail(),
            };

            // Very basic form of Dependency Injection
            Processor processor = new Processor(notifications);
            processor.Process();

            Console.ReadLine();
        }
    }
}