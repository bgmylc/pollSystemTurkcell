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
    public class PollService : IPollService
    {
        private pollSystemTurkcellDbContext dbContext;

        public PollService(pollSystemTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreatePoll(Poll poll)
        {
            dbContext.Polls.Add(poll);
            dbContext.SaveChanges();
        }

        public List<Poll> GetPolls()
        {
            return dbContext.Polls.Include(q => q.Questions)
                                   .Include(u => u.User)
                                   .Include(c => c.Creator)
                                   .AsNoTracking().ToList();
        }
    }
}
