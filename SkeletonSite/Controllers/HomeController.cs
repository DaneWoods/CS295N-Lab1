using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkeletonSite.Models;
using SkeletonSite.Repositories;

namespace SkeletonSite.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;

        public HomeController(IRepository r)
        {
            repo = r;
        }

        public ViewResult Index()
        {   
            ViewData["Title"] = "Home";
            return View();
        }

        public ViewResult History()
        {
            ViewData["Title"] = "History";
            return View();
        }

        [HttpGet]
        public ViewResult StoryPost()
        {
            ViewData["Title"] = "StoryPost";
            return View();
        }

        [HttpPost]
        public ViewResult StoryPost(Story post)
        {
            ViewData["Title"] = "StoryPost";
            if (ModelState.IsValid)
            {
                repo.AddStory(post);
                return View();
            }
            else
            {
                return View();
            }
        }
        
        public ViewResult Sources()
        {
            ViewData["Title"] = "Sources";
            return View();
        }

        public ViewResult StoryBoard()
        {
            ViewData["Title"] = "StoryBoard";
            return View(repo.StoryBank);
        }

        [HttpGet]
        public IActionResult Comment(string storyTitle)
        {
            ViewData["Title"] = "Comment";
            ViewBag.Story = storyTitle;
            return View("Comment", storyTitle);
        }

        [HttpPost]
        public IActionResult Comment(string subject, string storyTitle)
        {
            ViewBag.Story = storyTitle;
            ViewData["Title"] = "Comment";
            Comment com = new Comment();
            com.Text = subject;
            repo.Retrieve(storyTitle).Subjects.Add(com);
            return RedirectToAction("StoryBoard");
        }

        public ViewResult Books()
        {
            return View(BookCollection.Library);
        }

        public ViewResult Links()
        {
            return View(LinkCollection.Bank);
        }

        /* Lab 6
         * public ContentResult ContentMethod()
        {
            return Content("apples");
        }

        public NotFoundResult NotFoundMethod()
        {
            return NotFound();
        }

        public UnauthorizedResult UnauthMethod()
        {
            return Unauthorized();
        }*/
    }
}
