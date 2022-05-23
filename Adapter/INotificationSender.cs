using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface INotificationSender
    {
        void SendNotyfication(int userId, Notification notyfication);
    }
}
