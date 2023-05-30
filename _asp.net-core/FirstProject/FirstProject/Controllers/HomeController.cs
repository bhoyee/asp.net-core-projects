using FirstProject.Models;
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
 
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // TODO: store response from guest
            return View();
        }
    }
}