using System;

namespace OOP.Notification
{
    public class RahyabProvider : INotificationProvider
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Send {GetNotificationType()} to {to} message {message}");
        }

        public NotificationType GetNotificationType()
        {
            return NotificationType.Rahyab;
        }

        public bool ActiveProvider(List<NotificationType> notificationType)
        {
            var provider = this.GetNotificationType();
            return notificationType.ToList().Contains(provider);
        }
    }
}

