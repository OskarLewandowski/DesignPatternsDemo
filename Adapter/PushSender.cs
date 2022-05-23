using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PushSender : INotificationSender
    {
        public void SendNotyfication(int userId, Notification notyfication)
        {
            Console.WriteLine($"Sending push notification, to: {userId}\nTitle: {notyfication.Title}\nBody: {notyfication.Body}");
        }
    }
}
