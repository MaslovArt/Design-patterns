using System;

namespace Facade
{
    public class Credit
    {
        public bool CheckCredit(User user)
        {
            Console.WriteLine($"Checking credits for {user.Name}...");
            return true;
        }
    }
}
