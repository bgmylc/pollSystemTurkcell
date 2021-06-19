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

        public void CreateList(Poll poll)
        {
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderUrlAsPdf("https://localhost:44303/PollReply/AnswerDetails?pollID=" + poll.ID.ToString());
            var OutputPath = $"{poll.ID}_Liste.pdf";
            PDF.SaveAs(OutputPath);
        }

        public int GetPositiveResponses(int pollID, int quID)
        {
            var responses = dbContext.PollResponses.Where(r => r.PollID == pollID && r.QuestionID == quID)
                                                   .AsNoTracking().ToList();

            int positiveResponses = 0;

            foreach (var response in responses)
            {
                if (response.Answer == true)
                {
                    positiveResponses++;
                }
            }

            return positiveResponses;
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

        public List<PollResponse> GetResponsesByPoll(int pollID)
        {
            return dbContext.PollResponses.Include(p => p.Poll)
                                          .Include(q => q.Question)
                                          .Include(u => u.Respondent)
                                          .Where(r => r.PollID == pollID)
                                          .AsNoTracking().ToList();
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
