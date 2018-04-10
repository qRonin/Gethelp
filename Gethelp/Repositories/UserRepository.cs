using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gethelp.Models;

namespace Gethelp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ISet<User> _users = new HashSet<User>();

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(string email)
        => _users.Single(x => x.Email == email.ToLowerInvariant());

        public User Get(Guid id)
        => _users.Single(x => x.Id == id);

        public IEnumerable<User> GetAll()
        => _users;

        public void Remove(Guid id)
        { 
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user)
        {
            //
        }
    }
}