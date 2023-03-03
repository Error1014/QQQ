using Entities;
using Entities.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private readonly ContextDB _contextDB;
        public UserService(ContextDB contextDB)
        {
            _contextDB = contextDB;
        }
        public void AddUser(User user)
        {
            _contextDB.Users.Add(user);
            _contextDB.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _contextDB.Users.Find(id);
            _contextDB.Users.Remove(user);
            _contextDB.SaveChanges();
        }

        public User GetById(int id)
        {
           return _contextDB.Users.Find(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _contextDB.Users;
        }

        public void UpdateUser(User user)
        {
            _contextDB.Users.Update(user);
            _contextDB.SaveChanges();
        }
    }
}
