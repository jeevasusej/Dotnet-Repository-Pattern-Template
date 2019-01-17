using System;
using System.Collections.Generic;
using System.Text;
using Products.DomainModel;
using Products.Persistence.Contracts;
using System.Linq;

namespace Products.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext dbContext)
        {
            this.context = dbContext;
        }
        public void AddUser(User user)
        {
            context.Users.Add(user);
        }

        public bool DeleteUser(long userId)
        {
            var removed = false;
            User user = GetUser(userId);

            if (user != null)
            {
                removed = true;
                context.Users.Remove(user);
            }

            return removed;
        }

        public User GetUser(long Id)
        {
            return context.Users.Where(u => u.Id == Id).FirstOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users;
        }
    }
}
