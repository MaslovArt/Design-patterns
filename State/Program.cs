using State.Statuses;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("U1", new Bronze(), 10);
            account.Pay(75);
            account.TryUpgradeStatus();
            account.Pay(199);
            account.TryUpgradeStatus();
            account.Pay(200);
            account.TryUpgradeStatus();
            account.Pay(1000);
            account.TryUpgradeStatus();

            Console.ReadKey();
        }
    }
}
