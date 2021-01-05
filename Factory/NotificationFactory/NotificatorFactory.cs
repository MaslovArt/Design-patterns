namespace Factory.NotificationFactory
{
    public static class NotificatorFactory
    {
        public static INotificator Get(string type)
        {
            switch (type)
            {
                case "SMS": return new SMSNotificator();
                case "Vk": return new VkNotificator();
                case "EMail": return new EMailNotificator();
                default: return null;
            }
        }
    }
}
