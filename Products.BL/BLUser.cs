using Products.BL.Contracts;
using Products.DomainModel;
using Products.Persistence.Contracts.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.BL
{
    public class BLUser : IUser
    {
        private readonly IUnitOfWork uow;

        public BLUser(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public bool DeleteUser(long userId)
        {
            uow.User.DeleteUser(userId);
            uow.Complete();
            return true;
        }

        public User GetUser(long Id)
        {
            if (Id <= default(long))
                throw new ArgumentException("Invalid id");

            return uow.User.GetUser(Id);
        }

        public IEnumerable<User> GetUsers()
        {
            // We may implement validation like checking user roles
            return uow.User.GetUsers();
        }

        public User UpsertUser(User user)
        {
            if (user == null)
                throw new ArgumentException("Invalid user");

            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("Invalid user name");

            var _user = uow.User.GetUser(user.Id);
            if (_user == null)
            {
                _user = new User
                {
                    Name = user.Name
                };
                uow.User.AddUser(_user);
            }
            else
            {
                _user.Name = user.Name;
            }

            uow.Complete();

            return _user;
        }
    }
}
