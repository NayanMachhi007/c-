using Microsoft.AspNetCore.Mvc;
using pofo_corporate.Models;
using System.Diagnostics;

namespace pofo_corporate.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
