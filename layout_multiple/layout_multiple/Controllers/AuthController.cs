using Microsoft.AspNetCore.Mvc;

namespace layout_multiple.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult login()
        {
            return View();
        }

        public IActionResult forget()
        {
            return View();
        }
    }
}
