using pollSystemTurkcell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Services.Interfaces
{
    public interface IPollUserService
    {
        List<PollUser> GetPollUsers();
        void AddPollUser(PollUser pollUser);
        bool DoesRowExist(int userID, int pollID);
        int NoOfPeopleAnswered(int pollID);
        
    }
}
