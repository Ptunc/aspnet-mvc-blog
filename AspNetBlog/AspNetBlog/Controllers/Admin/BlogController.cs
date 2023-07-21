using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers.Admin
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
