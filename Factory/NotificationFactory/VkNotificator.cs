using System;

namespace Factory.NotificationFactory
{
    public class VkNotificator : INotificator
    {
        public void Notify(User user, string message)
        {
            Console.WriteLine($"Vk message for user {user.Name}: {message}");
        }
    }
}
