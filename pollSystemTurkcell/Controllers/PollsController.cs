using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using pollSystemTurkcell.Models;
using pollSystemTurkcell.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Threading;
using System.IO;
using NPOI.XWPF.UserModel;

namespace pollSystemTurkcell.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PollsController : Controller
    {
        private IPollService pollService;
        private IUserService userService;
        private IQuestionService questionService;
        private IPollUserService pollUserService;
        private IPollResponseService pollResponseService;

        public PollsController(IPollService pollService, IUserService userService, IQuestionService questionService, IPollUserService pollUserService, IPollResponseService pollResponseService)
        {
            this.pollService = pollService;
            this.userService = userService;
            this.questionService = questionService;
            this.pollUserService = pollUserService;
            this.pollResponseService = pollResponseService;
        }
        public IActionResult Index()
        {
            var polls = pollService.GetPolls().OrderByDescending(q => q.CreationDate); //Lists all existing polls
           
            return View(polls);
        }

        public IActionResult Create()
        {
            int creatorID = userService.GetIDByUsername(User.Identity.Name);
            ViewBag.CreatorID = creatorID;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Poll poll)
        {
            if (ModelState.IsValid) //If there are no errors; create the poll and return to the list
            {
                pollService.CreatePoll(poll);
                int pollID = poll.ID;
                return RedirectToAction("Details", "Polls", new { pollID });
            }

            return View(); //If there is an error open the same view again
        }
        //TODO 6: Deadline tarihinin geçmiş olmasını önleyemedim

        public IActionResult Delete(int pollID)
        {
            var poll = pollService.GetPollByID(pollID);

            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }

        [HttpPost]
        public IActionResult Delete(Poll poll)
        {

            pollService.DeletePoll(poll);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int pollID)
        {
            var poll = pollService.GetPollByID(pollID);
            ViewBag.CreationDate = poll.CreationDate;
            ViewBag.CreatorID = poll.CreatorID;
            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }

        [HttpPost]
        public IActionResult Edit(Poll poll)
        {
            if (ModelState.IsValid)
            {
                pollService.UpdatePoll(poll);
                return RedirectToAction(nameof(Index));
            }

            return View(poll);
        }

        public IActionResult Details(int pollID)
        {
            var poll = pollService.GetPollByID(pollID);
           
            IEnumerable<Question> questions = questionService.GetQuestionsByPollID(pollID);
            ViewBag.Questions = questions;

            ViewBag.NoOfAnswers = pollUserService.NoOfPeopleAnswered(pollID);

            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }

       

        public IActionResult DownloadList(string AnswerDetails, int pollID)
        {
           var poll = pollService.GetPollByID(pollID);
           pollResponseService.CreateList(poll);

            return View(poll); ;
        }
    }
}
