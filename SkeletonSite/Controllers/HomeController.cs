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
        public ViewResult Stories()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Stories(Story post)
        {
            if (ModelState.IsValid)
            {
                Board.AddStory(post);
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
            return View(Board.Bank);
        }
    }
}
