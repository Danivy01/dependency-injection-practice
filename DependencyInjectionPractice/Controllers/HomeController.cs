using System.Diagnostics;
using DependencyInjectionPractice.Models;
using DependencyInjectionPractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MessageService _messageService;
        private readonly DateService dateService;
        private readonly UserService userService;

        public HomeController(ILogger<HomeController> logger, MessageService messageService, DateService dateService, UserService userService)
        {
            _logger = logger;
            _messageService = messageService;
            this.dateService = dateService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            var result = $"Message: {_messageService.GetMessage()}\n" + $"User: {userService.GetUsername()}";
            return Content(result);
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
