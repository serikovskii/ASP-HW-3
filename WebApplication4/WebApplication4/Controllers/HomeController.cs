using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DownloadMusic(int music)
        {
            switch (music)
            {
                case 1: return File("~/music/deep.mp3", "audio/mpeg", "deep.mp3"); 
                case 2: return File("~/music/lounge.mp3", "audio/mpeg", "lounge.mp3"); 
                case 3: return File("~/music/club.mp3", "audio/mpeg", "club.mp3"); 
                case 4: return File("~/music/cover.mp3", "audio/mpeg", "cover.mp3");
                default: return HttpNotFound();
            }
            
        }
    }
}