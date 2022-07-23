using System;

namespace OOP.Notification
{
    public class FaraPayamakProvider : INotificationProvider
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Send {GetNotificationType()} to {to} message {message}");
        }

        public NotificationType GetNotificationType()
        {
            return NotificationType.Farapayamak;
        }

        public bool ActiveProvider(List<NotificationType> notificationType)
        {
            var provider = this.GetNotificationType();
            return notificationType.ToList().Contains(provider);
        }

        public bool Status()
        {
            return false;
        }
    }
}

