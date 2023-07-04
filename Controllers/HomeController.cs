using Microsoft.AspNetCore.Mvc;
using MVCS_architecture.Models;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace MVCS_architecture.Controllers
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

        [HttpPost]
        public IActionResult SubmitData(string message)
        {
            var viewModel = new SubmitViewModels
            {
                SummittedMessage = message
            };
            return View("Index", viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}