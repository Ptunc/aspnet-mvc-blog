﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Search(string query, int page)
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
