using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult login()
        {
            return View();
        }

        public IActionResult forgetpassword()
        {
            return View();
        }
    }
}
