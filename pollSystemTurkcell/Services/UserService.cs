using Microsoft.EntityFrameworkCore;
using pollSystemTurkcell.Data;
using pollSystemTurkcell.Models;
using pollSystemTurkcell.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Services
{
    public class UserService : IUserService
    {
        private pollSystemTurkcellDbContext dbContext;

        public UserService(pollSystemTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int GetIDByUsername(string username)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.UserName == username);
            return user.ID;
        }

        public User GetUserByID(int userID)
        {
            return dbContext.Users.Include(r => r.UserRole)
                                    .FirstOrDefault(i => i.ID == userID);
        }

        public string userRole(int userID)
        {
            var user = GetUserByID(userID);
            return user.UserRole.Name;
        }

        public User ValidUser(string username, string password)
        {
            return dbContext.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
