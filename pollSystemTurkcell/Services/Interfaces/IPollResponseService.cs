using pollSystemTurkcell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Services.Interfaces
{
    public interface IPollResponseService
    {
        void AddResponse(PollResponse pollResponse);
        bool CheckResponse(int userID, int quID);
        PollResponse GetResponseDetailsByID(int pollResponseID);
        PollResponse GetResponseByQuestionUser(int userID, int quID);
        List<PollResponse> GetResponsesByUserPoll(int userID, int pollID);
    }
}
