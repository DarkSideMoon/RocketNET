using System;
using System.Collections.Generic;
using System.Text;

namespace RocketNET.Notification.Builder
{
    public class NotificationBuilder
    {
        private readonly NotificationBuilderAbstract _notificationBuilder;

        public NotificationBuilder(NotificationBuilderAbstract builder)
        {
            this._notificationBuilder = builder;
        }
        public void Construct()
        {
            _notificationBuilder.BuildTopic();
            _notificationBuilder.BuildInformation();
        }
    }
}
