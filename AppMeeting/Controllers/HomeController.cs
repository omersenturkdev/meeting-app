using AppMeeting.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppMeeting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int userCount = Repository.Users.Where(i => i.WillAttend).Count();
            ViewBag.timeResult = DateTime.Now.Hour > 12 ? "İyi günler" : "Günaydın";
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, Haliç Kongre Merkezi",
                Date = new DateTime(2024, 5, 11, 20, 0, 0),
                NumberofPeople = userCount 
            };

            return View(meetingInfo);
        }
    }
}
