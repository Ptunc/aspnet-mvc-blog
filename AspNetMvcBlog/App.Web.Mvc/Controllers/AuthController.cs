using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult Login(string redirectUrl)
        {
            return View();
        }
        public IActionResult Register()
        {

            return View();
        }
    }
}
