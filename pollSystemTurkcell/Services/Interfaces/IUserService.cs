using pollSystemTurkcell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Services.Interfaces
{
    public interface IUserService
    {
        User ValidUser(string username, string password);
        string userRole(int userID);
    }
}
