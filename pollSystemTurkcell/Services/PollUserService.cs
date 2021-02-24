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
    public class PollUserService : IPollUserService
    {
        private pollSystemTurkcellDbContext dbContext;

        public PollUserService(pollSystemTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddPollUser(PollUser pollUser)
        {
            dbContext.PollUsers.Add(pollUser);
            dbContext.SaveChanges();
        }

        public bool DoesRowExist(int userID, int pollID)
        {
            bool exist = false;
            var row = dbContext.PollUsers.FirstOrDefault(p => p.PollID == pollID && p.UserID == userID);
            exist = row == null ? false : true;
            return exist;
        }

        public List<PollUser> GetPollUsers()
        {
            return dbContext.PollUsers.AsNoTracking().ToList();
        }

        public int NoOfPeopleAnswered(int pollID)
        {
            var answers = dbContext.PollUsers.Where(p => p.PollID == pollID);
            return answers.Count();
        }
    }
}
