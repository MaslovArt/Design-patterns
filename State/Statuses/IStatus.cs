namespace State.Statuses
{
    public interface IStatus
    {
        string Name { get; }
        double WithDiscount(double amount);
        IStatus TryUpgrade(double amount);
    }
}
