using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelefonDefteriService;

namespace TelefonDefteri.Web.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(string eMail, string password)
        {
            UserService userService = new UserService();

            var user = userService.Login(eMail, password);

            if (user != null && user.UserId != 0)
            {
                HttpContext.Session.SetString("user_email", user.Email);
                HttpContext.Session.SetString("user_name", user.Name);
                HttpContext.Session.SetString("user_lastName", user.LastName);
                HttpContext.Session.SetInt32("user_userId", user.UserId);


                return RedirectToAction("Index", "Home");
            }
            else
            {

                ViewBag.Message = string.Format("Hatalı Giriş");
                return RedirectToAction("Index", "Login");

            }
        }


        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }


        [HttpGet]
        public IActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewUser(string name, string lastName, string eMail, string password)
        {
            UserService userService = new UserService();
            TelefonDefteriEntity.User user = new TelefonDefteriEntity.User()
            {
                Email = eMail,
                LastName = lastName,
                Password = password,
                Name = name
            };
            bool isSave = userService.InsertUser(user);

            if (isSave)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }

    }
}
