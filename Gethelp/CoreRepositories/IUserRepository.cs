using Gethelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gethelp.Repositories
{
    public interface IUserRepository : IRepository
    {

        User Get(string email);     
        User Get(Guid id);
        void Add(User user);
        void Update(User user);
        void Remove(Guid id);
        IEnumerable<User> GetAll();

    }
}