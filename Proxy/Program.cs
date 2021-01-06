using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbStorage = new UsersStorage();
            PrintUser(dbStorage, 1);
            PrintUser(dbStorage, 1);

            Console.WriteLine("\nCached storage\n");

            var cachedStorage = new CachedUsersStorage();
            PrintUser(cachedStorage, 1);
            PrintUser(cachedStorage, 1);

            Console.ReadKey();
        }

        static void PrintUser(IUsersStorage storage, int id)
        {
            var user = storage.GetUser(id);
            if (user != null)
                Console.WriteLine(user);
        }
    }
}
