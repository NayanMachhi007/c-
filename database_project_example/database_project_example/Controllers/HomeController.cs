using database_project_example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace database_project_example.Controllers
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
            EmployeeModel employee = new EmployeeModel();

            employee.EmployeeId = 1;
            employee.EmployeeName = "Nayan";
            employee.EmployeeEmail = "nayankumarmachhi@gmail.com";
            employee.EmployeePhone = "9624502923";
            employee.status = true;
            
            return View(employee);
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
