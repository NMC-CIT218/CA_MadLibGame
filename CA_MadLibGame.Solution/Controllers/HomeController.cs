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
            storyText.Append($"You are my {Request.QueryString["adjective"]} love. You have me completely in your {Request.QueryString["noun"]}. ");
            storyText.Append($"I know and feel that if I am to {Request.QueryString["verb1"]} anything fine and noble ");
            storyText.Append($"in the future I shall do so only by {Request.QueryString["verbIng1"]} at the {Request.QueryString["nounPlural"]} of your heart. ");
            storyText.Append($"I would like to go through life {Request.QueryString["bodyPart"]} by {Request.QueryString["bodyPart"]} with you, {Request.QueryString["VerbIng2"]} you more and more until ");
            storyText.Append($"we {Request.QueryString["verbEd"]} to be {Request.QueryString["number"]} being(s) together until the hour should come for us to {Request.QueryString["verb2"]}.");

            ViewBag.StoryText = storyText.ToString();

            return View();
        }
    }
}