﻿using Microsoft.AspNetCore.Mvc;

namespace CloudantDotNetBoilerplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}