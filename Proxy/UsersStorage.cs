using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class UsersStorage : IUsersStorage
    {
        private User[] _dbUsers = new User[]
        {
            new User(1, "user1"),
            new User(2, "user2"),
            new User(3, "user3")
        };

        public User GetUser(int id)
        {
            Console.WriteLine("Getting from db...");
            return _dbUsers.FirstOrDefault(u => u.Id == id);
        }
    }
}
