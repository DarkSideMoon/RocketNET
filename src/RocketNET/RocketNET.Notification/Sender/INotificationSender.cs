using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RocketNET.Notification.Sender
{
    public interface INotificationSender
    {
        bool Send();

        Task<bool> SendAsync();
    }
}
