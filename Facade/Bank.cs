using System;

namespace Facade
{
    public class Bank
    {
        public bool CheckBank(User user)
        {
            Console.WriteLine($"Checking bank for {user.Name}...");
            return true;
        }
    }
}
