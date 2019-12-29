using AsgardApi.Repository.Databases;
using AsgardApi.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgardApi.Repository.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        User GetUserByEmail(string email);
        IEnumerable<User> GetAllUsers();
        bool UserExists(string email);
        void AddUser(User user);
        void UpdateUser(User user);
    }
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(x => x.Email == email);
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public bool UserExists(string email)
        {
            return _context.Users.Any(x => x.Email == email);
        }
    }
}
