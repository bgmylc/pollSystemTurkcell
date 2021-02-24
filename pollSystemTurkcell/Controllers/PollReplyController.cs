using Microsoft.AspNetCore.Mvc;
using pollSystemTurkcell.Models;
using pollSystemTurkcell.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Controllers
{
    public class PollReplyController : Controller
    {
        private IPollService pollService;
        private IUserService userService;
        private IQuestionService questionService;
        private IPollResponseService pollResponseService;
        private IPollUserService pollUserService;

        public PollReplyController(IPollService pollService, IUserService userService, IQuestionService questionService, IPollResponseService pollResponseService, IPollUserService pollUserService)
        {
            this.pollService = pollService;
            this.userService = userService;
            this.questionService = questionService;
            this.pollResponseService = pollResponseService;
            this.pollUserService = pollUserService;
        }
        public IActionResult Index()
        {
            var currentPolls = pollService.GetCurrentPolls();
            return View(currentPolls);
        }

        public IActionResult OldIndex()
        {
            var oldPolls = pollService.GetOldPolls();
            return View(oldPolls);
        }

        public IActionResult Poll(int pollID) 
        {

            var currentPoll = pollService.GetPollByID(pollID);
            ViewBag.PollName = currentPoll.Title;

            IEnumerable<Question> questions = questionService.GetQuestionsByPollID(pollID);
            ViewBag.Questions = questions;

            int RespondentID = userService.GetIDByUsername(User.Identity.Name);
            ViewBag.Response = pollResponseService.GetResponsesByUserPoll(RespondentID, pollID);

            bool check = false;

            foreach (var item in questions)
            {
                if (pollResponseService.CheckResponse(RespondentID, item.ID))
                {
                    check = true;
  
                }
            }
            if (check)
            {
                ViewBag.Message = 0;
            }
            
                return View(currentPoll);
            
           
        }

        public IActionResult Reply(int qID, int pollID)
        {
            ViewBag.RespondentID = userService.GetIDByUsername(User.Identity.Name);
            ViewBag.PollID = pollID;
            ViewBag.Question = questionService.GetQuestionByID(qID);

            return View();


        }

        [HttpPost]
        public IActionResult Reply(PollResponse pollResponse)
        {
            int RespondentID = userService.GetIDByUsername(User.Identity.Name);
            var poll = pollService.GetPollByID(pollResponse.PollID);

            if (ModelState.IsValid)
            {
                pollResponseService.AddResponse(pollResponse);
                bool rowCheck = pollUserService.DoesRowExist(RespondentID, poll.ID);
                if (!rowCheck)
                {
                    PollUser pollUser = new PollUser();
                    pollUser.PollID = pollResponse.PollID;
                    pollUser.UserID = RespondentID;
                    pollUserService.AddPollUser(pollUser);
                }
                

                return RedirectToAction("Poll", "PollReply", new { pollResponse.PollID });

            }

            
            return View();

        }

        public IActionResult ResponseDetails(int quID)
        {
            ViewBag.Question = questionService.GetQuestionByID(quID);
            int userID = userService.GetIDByUsername(User.Identity.Name);
            var response = pollResponseService.GetResponseByQuestionUser(userID, quID);
            return View(response);
        }

        public IActionResult Details(int pollID)
        {
            var poll = pollService.GetPollByID(pollID);
            ViewBag.NoOfAnswers = pollUserService.NoOfPeopleAnswered(pollID);

            IEnumerable<Question> questions = questionService.GetQuestionsByPollID(pollID);
            ViewBag.Questions = questions;

            if (poll == null)
            {
                return NotFound();
            }
            return View(poll);
        }
        
    }
}
