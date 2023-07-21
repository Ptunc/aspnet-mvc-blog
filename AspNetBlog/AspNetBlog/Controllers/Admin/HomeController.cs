using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers.Admin
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
