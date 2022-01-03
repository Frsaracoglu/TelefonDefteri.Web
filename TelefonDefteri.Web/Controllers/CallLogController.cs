using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelefonDefteriService;

namespace TelefonDefteri.Web.Controllers
{
    public class CallLogController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var userId = (int)HttpContext.Session.GetInt32("user_userId");

            CallLogService servis = new();
            var result = servis.CallLogListPeople(userId);
            return View(result);
        }

        [HttpPost]
        public IActionResult GetCallListDetail(int listId)
        {
            CallLogService servis = new();
            var result = servis.GetCallListDetail(listId);
            return Json(result);
        }

    }
}
