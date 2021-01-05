using System;

namespace Factory.NotificationFactory
{
    public class EMailNotificator : INotificator
    {
        public void Notify(User user, string message)
        {
            Console.WriteLine($"Email for {user.Name}: {message}");
        }
    }
}
