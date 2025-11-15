using System.Diagnostics;
using HrApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace HrApplication.Controllers
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

        [HttpGet]
        public IActionResult employees()
        {
            return View();
        }

        [HttpPost]
        public IActionResult employees(employeescshtml x)
        {
            if (ModelState.IsValid)
            {
                repository.addemployee(x);
                _logger.LogInformation("New employee added: {Name}", x.name);
                return View("confirmpage", x);
            }
            return View(x);
        }

        public IActionResult allemployees()
        {
            return View(repository.getemployees());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
