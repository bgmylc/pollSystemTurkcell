using Microsoft.AspNetCore.Mvc;
using pollSystemTurkcell.Models;
using pollSystemTurkcell.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Controllers
{
    public class PollReplyController : Controller
    {
        private IPollService pollService;
        private IUserService userService;
        private IQuestionService questionService;

        public PollReplyController(IPollService pollService, IUserService userService, IQuestionService questionService)
        {
            this.pollService = pollService;
            this.userService = userService;
            this.questionService = questionService;
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

        public IActionResult Reply(int pollID) //TODO 7: Bu reply kısmını Polls'taki details gibi yap, her soru yeni bir sayfada yanıtlansın. Vallaha yoruldum.
        {
            ViewBag.RespondentID =  userService.GetIDByUsername(User.Identity.Name);

            var currentPoll = pollService.GetPollByID(pollID);
            ViewBag.PollName = currentPoll.Title;
            ViewBag.PollID = pollID;

            IEnumerable<Question> questions = questionService.GetQuestionsByPollID(pollID);
            ViewBag.Questions = questions;

            return View();
        }
    }
}
