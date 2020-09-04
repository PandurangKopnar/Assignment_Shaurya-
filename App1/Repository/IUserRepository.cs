using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUser();
        User GetUserByID(int UserID);
        void InsertUser(User user);
        void DeleteUser(int UserID);
        void UpdateUser(User user);
        void Save();
        void UpdatePhotopath(int userId, string Photopath);
    }
}
