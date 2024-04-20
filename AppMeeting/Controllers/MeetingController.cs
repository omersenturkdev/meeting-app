using AppMeeting.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppMeeting.Controllers
{
    public class MeetingController : Controller
    {
       
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
           Repository.CreateUser(model);
           ViewBag.userCount = Repository.Users.Where(user=> user.WillAttend).Count();
           return View("Thanks", model);
        }

        public IActionResult List()
        {
            var user = Repository.Users;
            return View(user);
        }
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

    }
}
