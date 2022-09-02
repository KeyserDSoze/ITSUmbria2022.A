using ITSUmbria2022.Blackjack.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITSUmbria2022.Blackjack.MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameManager _gameManager;

        public HomeController(ILogger<HomeController> logger,
            IGameManager gameManager)
        {
            _logger = logger;
            _gameManager = gameManager;
        }

        public IActionResult Index()
        {
            return View(_gameManager);
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