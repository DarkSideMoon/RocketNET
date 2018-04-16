using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RocketNET.Notification.Sender
{
    public class EmailSender : INotificationSender
    {
        public bool Send()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendAsync()
        {
            throw new NotImplementedException();
        }
    }
}
