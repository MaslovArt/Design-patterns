namespace State.Statuses
{
    public class Bronze : IStatus
    {
        public string Name => "Bronze";

        public IStatus TryUpgrade(double amount) =>
            amount > 100 ? (IStatus)new Silver() : this;

        public double WithDiscount(double amount) => amount * 0.9;
    }
}
