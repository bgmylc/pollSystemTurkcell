using pollSystemTurkcell.Models;
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
    }
}
