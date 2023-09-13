using Microsoft.AspNetCore.Mvc;
using SRK.Models;
using System.Diagnostics;

namespace SRK.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TechnicalInfoPartial()
        {
            return View();
        }

        // Action method for the "Articles" view
        public IActionResult Articles()
        {
            return View();
        }

        // Action method for handling the submission of new articles
        [HttpPost]
        public IActionResult SubmitArticle(string articleTitle, string articleAuthor, DateTime articleDate, string articleDescription)
        {
            // Handle the submission logic here (e.g., save the article to a database)
            // You can access the form data via the parameters

            // Redirect back to the Articles view or another appropriate page
            return RedirectToAction("Articles");
        }

        // Action method for the "Books" view
        public IActionResult Books()
        {
            return View();
        }

        // Action method for handling the submission of new books
        [HttpPost]
        public IActionResult SubmitBook(string bookTitle, string bookAuthor, string publicationYear, string bookDescription)
        {
            // Handle the submission logic here (e.g., save the book to a database)
            // You can access the form data via the parameters

            // Redirect back to the Books view or another appropriate page
            return RedirectToAction("Books");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}