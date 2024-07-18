using Microsoft.AspNetCore.Mvc;
using model_example.Models;
using System.Diagnostics;

namespace model_example.Controllers
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
           
            EmployeeModel empobject = new EmployeeModel();

            empobject.emp_id = 1;
            empobject.emp_Name = "Nayan";
            empobject.emp_email = "nayankumarmachhi@gmail.com";
            empobject.emp_mobile = "9624502923";
            empobject.emp_status = true;

            return View(empobject);
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
