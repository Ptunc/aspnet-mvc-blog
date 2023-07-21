using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers.Admin
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
