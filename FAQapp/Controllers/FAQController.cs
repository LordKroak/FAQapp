using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FAQapp.Models;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace FAQapp.Controllers
{
    public class FAQController : Controller
    {
        private FAQContext context;

        public FAQController(FAQContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List", "Question");
        }

        [Route("[controller]/{cat?}")]
        public IActionResult List(string cat = "All")
        {
            /* var categories = context.Categories
                .OrderBy(c => c.CategoryID).ToList();

            var topics = context.Topics
                .OrderBy(t => t.TopicID).ToList();

            List<Question> questions;
            if (id == "All")
            {
                questions = context.Questions
                    .OrderBy(p => p.QuestionID).ToList();
            }
            else
            {
                questions = context.Questions
                    .Where(p => p.Category.Name == id)
                    .Where(p => p.Topic.Name == id)
                    .OrderBy(p => p.QuestionID).ToList();
            }

            // use ViewBag to pass data to view
            ViewBag.Categories = categories;
            ViewBag.SelectedCategoryName = id;

            // bind products to view
            return View(questions);
            */ // View method above
            return Content("FAQ controller, List action, Category: " + cat);
        }

        public IActionResult Details(int id)
        {
            var categories = context.Categories
                .OrderBy(c => c.CategoryID).ToList();

            var topics = context.Topics
                .OrderBy(t => t.TopicID).ToList();

            Question question = context.Questions.Find(id);

            // use ViewBag to pass data to view
            ViewBag.Categories = categories;

            // bind question to view
            return View(question);
        }
        
    }
}
