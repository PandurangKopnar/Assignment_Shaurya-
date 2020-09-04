using App1.DBContexts;
using App1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _dbContext;
        public UserRepository(UserContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteUser(int UserID)
        {
            var user = _dbContext.Users.Find(UserID);
            _dbContext.Users.Remove(user);
            Save();
        }

        public User GetUserByID(int userID)
        {
            return _dbContext.Users.Find(userID);
        }

        public IEnumerable<User> GetUser()
        {
            return _dbContext.Users.ToList();
        }

        public void InsertUser(User user)
        {
            _dbContext.Add(user);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            Save();
        }
        public void UpdatePhotopath(int userId, string Photopath)
        {
            var user = new User() { UserID = userId, Photopath = Photopath };
            _dbContext.Users.Attach(user);
            _dbContext.Entry(user).Property(x => x.Photopath).IsModified = true;
            Save();
        }
        

    }
}
