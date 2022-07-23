using System;
namespace OOP.Notification
{
    public interface INotificationProvider
    {
        void Send(string to, string message);
        NotificationType GetNotificationType();
        bool ActiveProvider(List<NotificationType> notificationType);
        bool Status();
    }
}

