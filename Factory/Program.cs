using Factory.NotificationFactory;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var SMS = "SMS";
            var VK = "Vk";
            var EMAIL = "EMail";

            var users = new User[]
            {
                new User("User1", SMS),
                new User("User2", SMS),
                new User("User3", VK),
                new User("User4", VK),
                new User("User5", EMAIL),
                new User("User6", "abc")
            };

            foreach (var user in users)
            {
                var notificator = NotificatorFactory.Get(user.NotificationType);
                if (notificator != null)
                {
                    notificator.Notify(user, "Your promocode for free coffe: FREECOFEE");
                }
                else
                {
                    Console.WriteLine($"Notificator not found! ['{user.Name}', '{user.NotificationType}'");
                }
            }

            Console.ReadKey();
        }
    }
}
