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
            return View();
        }

        public ViewResult History()
        {
            return View();
        }

        [HttpGet]
        public ViewResult StoryPost()
        {
            return View();
        }

        [HttpPost]
        public ViewResult StoryPost(Story post)
        {
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
            return View();
        }

        public ViewResult Books()
        {
            return View(BookCollection.Library);
        }

        public ViewResult Links()
        {
            return View(LinkCollection.Bank);
        }

        public ViewResult StoryBoard()
        {
            return base.View(Models.Stories.StoryBank);
        }

        [HttpGet]
        public ViewResult Comment(string storyTitle)
        {
            return View("Comment", storyTitle);
        }

        [HttpPost]
        public ViewResult Comment(string subject, string storyTitle)
        {
            Comment com = new Comment();
            com.Text = subject;
            Stories.Retrieve(storyTitle).Subjects.Add(com);
            return View("Comment", storyTitle);
        }
    }
}
