using System;
using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
    public class CachedUsersStorage : IUsersStorage
    {
        private List<User> _cache = new List<User>();
        private UsersStorage _usersStorage = new UsersStorage();

        public User GetUser(int id)
        {
            var cachedUser = _cache.FirstOrDefault(u => u.Id == id);
            if (cachedUser != null)
            {
                Console.WriteLine("Getting from cache...");
                return cachedUser;
            }

            var user = _usersStorage.GetUser(id);

            if (user != null) 
                _cache.Add(user);

            return user;
        }
    }
}
