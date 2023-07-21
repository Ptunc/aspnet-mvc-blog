using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers.Admin
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
