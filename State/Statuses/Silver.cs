namespace State.Statuses
{
    public class Silver : IStatus
    {
        public string Name => "Silver";

        public IStatus TryUpgrade(double amount) => 
            amount > 300 ? (IStatus)new Gold() : this;

        public double WithDiscount(double amount) => amount * 0.75;
    }
}
