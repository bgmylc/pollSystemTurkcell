using pollSystemTurkcell.Models;
using pollSystemTurkcell.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Services.FakeServices
{
    public class FakeUserService : IUserService
    {
        private List<User> users = new List<User>
        {
            new User{Name = "Segum", Surname="Yolcu", UserName="segum123", Email="segum@segum.com", Password="flokifloki23",  PhoneNumber="1234567899", UserRole = new UserRole{ Name="User" } },
            new User{Name = "Begum", Surname="Yolcu", UserName="begum123", Email="begum@segum.com", Password="floki23",  PhoneNumber="1234567899", UserRole = new UserRole{ Name="User" } },
            new User{Name = "Floki",Surname="Yolcu", UserName="floskos123", Email="floki@segum.com", Password="segumfloki23", PhoneNumber="9987654321" , UserRole = new UserRole{ Name = "Admin" } }
        };

        public string userRole(int userID)
        {
            throw new NotImplementedException();
        }

        public User ValidUser(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
