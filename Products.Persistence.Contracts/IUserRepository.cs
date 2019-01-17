using Products.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Persistence.Contracts
{
    public interface IUserRepository
    {
        void AddUser(User user);
        IEnumerable<User> GetUsers();
        bool DeleteUser(long userId);
        User GetUser(long Id);
    }
}
