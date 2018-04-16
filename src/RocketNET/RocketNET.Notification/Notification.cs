using RocketNET.Notification.Enums;

namespace RocketNET.Notification
{
    /// <summary>
    /// DTO of notification
    /// </summary>
    public class Notification
    {
        public int Id { get; set; }

        public Level Level { get; set; }

        public Topic Topic { get; set; }

        /// <summary>
        /// Whole information in notification
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Small part information in notification
        /// </summary>
        public string Information { get; set; }
    }
}
