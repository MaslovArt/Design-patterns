using System;

namespace Facade
{
    public class Work
    {
        public bool CheckWork(User user)
        {
            Console.WriteLine($"Checking work for {user.Name}...");
            return true;
        }
    }
}
