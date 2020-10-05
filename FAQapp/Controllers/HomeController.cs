using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FAQapp.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQapp.Controllers
{
    public class HomeController : Controller
    {
        private FAQContext context { get; set; }

        public HomeController(FAQContext ctx)
        {
            context = ctx;
        }

        //[Route("/")]
        public IActionResult Index()
        {
            var questions = context.Questions
                .Include(q => q.Category)
                .Include(q => q.Topic)
                .OrderBy(q => q.FAQ)
                .ToList();
            return View(questions);
            //return Content("Home controller, Index action");
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return Content("Home controller, About action");
        }
    }
}
