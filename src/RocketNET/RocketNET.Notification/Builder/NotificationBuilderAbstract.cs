using System;
using System.Collections.Generic;
using System.Text;

namespace RocketNET.Notification.Builder
{
    public abstract class NotificationBuilderAbstract
    {
        public abstract void BuildTopic();

        public abstract void BuildInformation();

        public abstract void BuildLogInfo();

        public abstract void BuildProviderInfo();

        public abstract void BuildOtherInfo();

        public abstract Notification GetNotification();
    }
}
