using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationSender notificationEmailSender = new EmailSender();
            notificationEmailSender.SendNotyfication(5, new Notification() { Title = "Test", Body = "Test ćżśżćź" });

            INotificationSender notificationPushSender = new PushSender();
            notificationPushSender.SendNotyfication(6, new Notification() { Title = "Test", Body = "Test ćżśżćź" });

            INotificationSender notificationSmsSender = new SmsSenderAdapter();
            notificationSmsSender.SendNotyfication(7, new Notification() { Title = "Test", Body = "Test ćżśżćź" });


            Console.ReadLine();
        }
    }
}
