using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers.Admin
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
