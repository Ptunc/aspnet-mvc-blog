using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers
{
    public class PageController : Controller
    {
        public ActionResult Detail(int id)
        {
            return View();
        }

    }
}
