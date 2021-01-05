using System;

namespace Factory.NotificationFactory
{
    public class SMSNotificator : INotificator
    {
        public void Notify(User user, string message)
        {
            Console.WriteLine($"SMS for user {user.Name}: {message}");
        }
    }
}
