﻿using pollSystemTurkcell.Models;
using pollSystemTurkcell.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Services.FakeServices
{
    public class FakePollService : IPollService
    {
        public void CreatePoll(Poll poll)
        {
            throw new NotImplementedException();
        }

        public void DeletePoll(Poll poll)
        {
            throw new NotImplementedException();
        }

        public Poll GetPollByID(int pollID)
        {
            throw new NotImplementedException();
        }

        public List<Poll> GetPolls()
        {
            throw new NotImplementedException();
        }

        public void UpdatePoll(Poll poll)
        {
            throw new NotImplementedException();
        }
    }
}
