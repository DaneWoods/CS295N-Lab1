using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkeletonSite.Models;

namespace SkeletonSite.Controllers
{
    public class HomeController : Controller
    {
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
                Models.Stories.AddStory(post);
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

        public ViewResult Books()
        {
            ViewData["Title"] = "Books";
            ViewData["Heading"] = "Books and print media within the table";
            ViewData["THeader"] = "Books from: ";
            return View(BookCollection.Library);
        }

        public ViewResult Links()
        {
            ViewData["Title"] = "Links";
            ViewData["Heading"] = "Links to online media Below";
            ViewData["THeader"] = "Links to wikipedia giving info about: ";
            return View(LinkCollection.Bank);
        }

        public ViewResult StoryBoard()
        {
            ViewData["Title"] = "StoryBoard";
            return View(Models.Stories.StoryBank);
        }

        [HttpGet]
        public ViewResult Comment(string storyTitle)
        {
            ViewData["Title"] = "Comment";
            ViewBag.Story = storyTitle;
            return View("Comment", storyTitle);
        }

        [HttpPost]
        public ViewResult Comment(string subject, string storyTitle)
        {
            ViewData["Title"] = "Comment";
            Comment com = new Comment();
            com.Text = subject;
            Stories.Retrieve(storyTitle).Subjects.Add(com);
            return View("Comment", storyTitle);
        }
    }
}
