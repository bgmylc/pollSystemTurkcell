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
    public class PollResponseService : IPollResponseService
    {
        private pollSystemTurkcellDbContext dbContext;

        public PollResponseService(pollSystemTurkcellDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddResponse(PollResponse pollResponse)
        {
            dbContext.PollResponses.Add(pollResponse);
            dbContext.SaveChanges();
        }

        public bool CheckResponse(int userID,int quID)
        {

            var existingResponse = dbContext.PollResponses.FirstOrDefault(r => r.RespondentID == userID && r.QuestionID == quID );
            bool doesItExist = existingResponse == null ? false : true;

            return doesItExist;

        }

        public PollResponse GetResponseByQuestionUser(int userID, int quID)
        {
            return dbContext.PollResponses.FirstOrDefault(r => r.RespondentID == userID && r.QuestionID == quID);
        }

        public PollResponse GetResponseDetailsByID(int pollResponseID)
        {
            return dbContext.PollResponses.Include(p => p.Poll)
                                          .Include(q => q.Question)
                                          .FirstOrDefault(r => r.ID == pollResponseID);
                                          

        }

        public List<PollResponse> GetResponsesByUserPoll(int userID, int pollID)
        {
            return dbContext.PollResponses.Where(u => u.RespondentID == userID && u.PollID == pollID)
                                          .Include(p => p.Poll)
                                          .Include(q => q.Question)
                                          .AsNoTracking().ToList();
                                  
        }
    }
}
