﻿using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    int hour = DateTime.Now.Hour;
        //    string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
        //    return View("MyView", viewModel);
        //}
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}