using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using pollSystemTurkcell.Models;
using pollSystemTurkcell.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollSystemTurkcell.Controllers
{
    public class QuestionsController : Controller
    {
        private IPollService pollService;
        private IQuestionService questionService;

        public QuestionsController(IPollService pollService, IQuestionService questionService)
        {
            this.pollService = pollService;
            this.questionService = questionService;
        }

        public IActionResult Create(int pollID)
        {
            ViewBag.PollName = pollService.GetPollByID(pollID).Title;
            ViewBag.PollID = pollID; 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Question question)
        {

            if (ModelState.IsValid)
            {
                questionService.Add(question);
                return RedirectToAction("Details", "Polls", new { question.PollID });

            }


            return View();

        }

        public IActionResult Delete(int qID)
        {
            var question = questionService.GetQuestionByID(qID);
            ViewBag.PollName = pollService.GetPollByID(question.PollID).Title;

            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        [HttpPost]
        public IActionResult Delete(Question question)
        {

            questionService.DeleteQuestion(question);
            return RedirectToAction("Details", "Polls", new { question.PollID });

        }

        public IActionResult Edit(int qID)
        {
            var question = questionService.GetQuestionByID(qID);
            ViewBag.PollName = pollService.GetPollByID(question.PollID).Title;
           
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        [HttpPost]
        public IActionResult Edit(Question question)
        {
            if (ModelState.IsValid)
            {
                questionService.UpdateQuestion(question);
                return RedirectToAction("Details", "Polls", new { question.PollID });
            }

            return View(question);
        }
    }
}
