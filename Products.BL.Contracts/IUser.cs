using Products.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.BL.Contracts
{
    public interface IUser
    {
        User UpsertUser(User user);
        IEnumerable<User> GetUsers();
        bool DeleteUser(long userId);
        User GetUser(long Id);
    }
}
