using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesRefresher
{
    public class Processor : IProcessor
    {
        // COMPOSITION
        private List<INotification> _notifications;

        public Processor(List<INotification> notification)
        {
            _notifications = notification;
        }

        public void Process()
        {
            // Perform encoding magic
            // ...


            // If finshed -> Notify user
            NotifyUser(_notifications);
        }

        // POLYMORPHISM
        private void NotifyUser(List<INotification> notifications)
        {
            foreach (INotification notification in notifications)
            {
                notification.Send();


                // IS -> Is this object a type of
                if (notification is IFastMover)
                {
                    // Convert to another interface that this object also inherits from
                    var fastMover = (IFastMover)notification;
                    fastMover.SameDayDelivery();

                    //((IFastMover)notification).SameDayDelivery();
                }

                // AS -> Try to convert immediately. Regardless of whether it is a type
                IFastMover fastMover2 = notification as IFastMover;

                if (fastMover2 != null)
                {
                    fastMover2.SameDayDelivery();
                }
            }
        }
    }
}
