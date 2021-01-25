using System;

namespace InterfacesRefresher
{

    // Classes can inherit from multiple Interfaces
    public class Email : INotification, IFastMover
    {
        public string EmailAddress { get; set; }

        public void SameDayDelivery()
        {
            Console.WriteLine("Email has arrived after 1 minute.");
        }

        public void Send()
        {
            Console.WriteLine("Email has been sent");
        }
    }

    public class Sms : INotification, IFastMover
    {
        public string Telephone { get; set; }

        public void SetProvider()
        {
            // ...
        }

        public void Send()
        {
            Console.WriteLine("Sms has been sent");
        }

        public void SameDayDelivery()
        {
            Console.WriteLine("Sms has arrived after 200ms.");
        }
    }

    public class Mail : INotification
    {
        public void Send()
        {
            Console.WriteLine("Mail has been sent");
        }
    }

    // OPEN / CLOSED PRINCIPLE: Modify behaviour without modifying existing code
    public class PostDuif : INotification
    {
        public void Send()
        {
            Console.WriteLine("Roekoe");
        }
    }
}