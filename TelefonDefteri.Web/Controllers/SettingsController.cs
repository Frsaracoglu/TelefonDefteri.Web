using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelefonDefteriEntity;
using TelefonDefteriService;

namespace TelefonDefteri.Web.Controllers
{
    public class SettingsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult UpdateUser(string name, string lastName, string eMail, string password)
        {
            UserService userService = new UserService();
            User user = new User()
            {
                Email = eMail,
                LastName = lastName,
                Password = password,
                Name = name
            };
            bool isUpdate = userService.UpdateUser(user);

            if (isUpdate)
            {
                return Json("Kullanıcı Güncellendi");
            }
            else
            {
                return Json("Kullanıcı Güncellendi");
            }
        }
    }
}
