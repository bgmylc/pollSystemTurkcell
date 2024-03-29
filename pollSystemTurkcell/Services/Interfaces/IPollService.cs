﻿using pollSystemTurkcell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Services.Interfaces
{
    public interface IPollService
    {
        List<Poll> GetPolls();
        void CreatePoll(Poll poll);
        Poll GetPollByID(int pollID);
        void DeletePoll(Poll poll);
        void UpdatePoll(Poll poll);
        List<Poll> GetCurrentPolls();
        List<Poll> GetOldPolls();
        bool PollResponsesComplete(int userID, Poll poll);
        void AlertByMail(Poll poll, Question question, User user);
       
    }
}
