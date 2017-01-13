using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CA_MadLibGame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayStory()
        {
            StringBuilder storyText = new StringBuilder();

            storyText.Clear();
            storyText.Append($"You are my {1} love.You have me completely in your {2}.");


            //I know and feel that if I am to 3 anything fine and noble in the future I shall do so only by 4 at the 5 of your heart.I would like to go through life 6 by 6 with you, 7 you more and more until we 8 to be 9 being(s) together until the hour should come for us to 10.

            ViewBag.StoryText = storyText.ToString();

            return View();
        }
    }
}