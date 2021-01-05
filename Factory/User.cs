namespace Factory
{
    public class User
    {
        public User(string name, string notificationType)
        {
            Name = name;
            NotificationType = notificationType;
        }

        public string Name { get; set; }
        public string NotificationType { get; set; }
    }
}
