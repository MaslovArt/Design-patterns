using State.Statuses;
using System;

namespace State
{
    public class Account
    {
        public string Name { get; set; }
        public IStatus Status { get; set; }
        public double SpentAmount { get; set; }

        public Account(string name, IStatus status, double spent)
        {
            Name = name;
            Status = status;
            SpentAmount = spent;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Price {amount}");
            var specialPrice = Status.WithDiscount(amount);
            Console.WriteLine($"Special price for '{Status.Name} is {specialPrice}'");

            SpentAmount += specialPrice;
        }

        public void TryUpgradeStatus()
        {
            var oldStatus = Status;
            Status = Status.TryUpgrade(SpentAmount);

            if (oldStatus.Name != Status.Name)
                Console.WriteLine($"Upgrade status {oldStatus.Name} -> {Status.Name}");
        }
    }
}
