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

namespace pollSystemTurkcell.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PollsController : Controller
    {
        private IPollService pollService;
        private IUserService userService;

        public PollsController(IPollService pollService, IUserService userService)
        {
            this.pollService = pollService;
            this.userService = userService;
        }
        public IActionResult Index()
        {
            var polls = pollService.GetPolls(); //Lists all existing polls
           
            return View(polls);
        }

        public IActionResult Create()
        {
            int creatorID = userService.GetIDByUsername(User.Identity.Name);
            ViewBag.CreatorID = creatorID;

            return View();
        }

        //TODO 6: Poll için create, edit, delete ve details yapacağız
        //TODO 7: Poll için soru oluşturma kısmı olmadı
        [HttpPost]
        public IActionResult Create(Poll poll)
        {
            if (ModelState.IsValid) //If there are no errors; create the poll and return to the list
            {
                pollService.CreatePoll(poll);
                return RedirectToAction(nameof(CreateQuestions));
            }

            return View(); //If there is an error open the same view again
        }

        public IActionResult CreateQuestions(Poll poll)
        {
            ViewBag.PollID = poll.ID;
            ViewBag.NoOfQ = poll.NoOfQuestions;
            return View();
        }
    }
}
