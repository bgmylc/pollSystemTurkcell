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

        public void DeletePoll(Poll poll)
        {
            dbContext.Remove(poll);
            dbContext.SaveChanges();
        }

        public List<Poll> GetCurrentPolls()
        {
            DateTime now = DateTime.Now;
            return dbContext.Polls.Where(d => d.Deadline.CompareTo(now) > 0)
                                  .Include(c => c.Creator)
                                  .AsNoTracking().ToList();
           
        }

        public List<Poll> GetOldPolls()
        {
            DateTime now = DateTime.Now;
            return dbContext.Polls.Where(d => d.Deadline.CompareTo(now) < 0)
                                  .Include(c => c.Creator)
                                  .AsNoTracking().ToList();
        }

        public Poll GetPollByID(int pollID)
        {
            return dbContext.Polls.Include(q => q.Questions)
                                  .Include(u => u.User)
                                  .Include(c => c.Creator)
                                  .FirstOrDefault(i => i.ID == pollID);
        }

        public List<Poll> GetPolls()
        {
            return dbContext.Polls.Include(q => q.Questions)
                                   .Include(u => u.User)
                                   .Include(c => c.Creator)
                                   .AsNoTracking().ToList();
        }

        public bool PollResponsesComplete(int userID, Poll poll)
        {
            bool complete = true;
            int check = 0;
            foreach (var response in poll.PollResponses)
            {
                foreach (var question in poll.Questions)
                {
                    if (question.ID == response.QuestionID)
                    {
                        check++;
                    }
                }
            }
            complete = check == poll.Questions.Count ? true : false;
           
            return complete;
        }

        public void UpdatePoll(Poll poll)
        {
            dbContext.Entry(poll).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
