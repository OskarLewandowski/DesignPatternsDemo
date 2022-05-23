using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _smsSender = new SmsSender();

        public void SendNotyfication(int userId, Notification notyfication)
        {
            // we can here take a required data 
            string userPhoneNumber = "999888777"; //based on UserId

            string text = $"{notyfication.Title} {notyfication.Body}";

            _smsSender.SendSms(userPhoneNumber, text);
        }
    }
}
