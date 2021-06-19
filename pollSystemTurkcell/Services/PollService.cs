using Microsoft.EntityFrameworkCore;
using pollSystemTurkcell.Data;
using pollSystemTurkcell.Models;
using pollSystemTurkcell.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        public void AlertByMail(Poll poll, Question question, User user)
        {

            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("greencare465@gmail.com");
            
            ePosta.To.Add(user.Email);
            ePosta.Subject = $"{poll.Title} Anketi Onayları";
            ePosta.Body = $" Merhaba, {user.UserName}, {poll.Title} isimli anketinin, {question.Text} sorusu yeterli onay sayısına ulaştı!";
            
            SmtpClient smtp = new SmtpClient();
            
            smtp.Credentials = new System.Net.NetworkCredential("greencare465@gmail.com", "B78a51-0");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            try
            {
                smtp.Send(ePosta);
            }
            catch (SmtpException)
            {

            }
       
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

