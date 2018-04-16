using System;
using RocketNET.Notification.Enums;

namespace RocketNET.Notification.Sender
{
    public static class SenderProviderFactory
    {
        public static INotificationSender GetSenderProviderFactory(string name)
        {
            throw new NotImplementedException();
        }

        public static INotificationSender GetSenderProviderFactory(SenderType senderType)
        {
            switch (senderType)
            {
                case SenderType.Email:
                    return new EmailSender();
            }

            return null;
        }
    }
}
