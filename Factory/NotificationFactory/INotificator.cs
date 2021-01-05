namespace Factory.NotificationFactory
{
    public interface INotificator
    {
        void Notify(User user, string message);
    }
}
