namespace State.Statuses
{
    public class Gold : IStatus
    {
        public string Name => "Gold";

        public IStatus TryUpgrade(double amount) => this;

        public double WithDiscount(double amount) => amount * 0.5;
    }
}
