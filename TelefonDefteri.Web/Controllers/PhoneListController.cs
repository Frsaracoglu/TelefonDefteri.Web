using Microsoft.AspNetCore.Mvc;
using TelefonDefteriEntity;
using TelefonDefteriService;

namespace TelefonDefteri.Web.Controllers
{
    public class PhoneListController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            PhoneListService phoneListService = new PhoneListService();
            var result = phoneListService.ListPeople();
            return View(result);
        }

        [HttpGet]
        public IActionResult NewList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewList(string eMail, string lastName, string name, string address, string phone, string city, bool status)
        {
            PhoneListService pls = new();
            TelefonDefteriData.Models.PhoneList list = new()
            {
                Email = eMail,
                LastName = lastName,
                Name = name,
                Address = address,
                Phone = phone,
                City = city,
                Status = status
            };
            bool isSave = pls.ListAdd(list);

            if (isSave)
            {
                return RedirectToAction("Index", "PhoneList");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Update(int listId)
        {
            PhoneListService pls = new();

            var people = pls.GetPeople(listId);

            return View(people);
        }

        [HttpPost]
        public IActionResult UpdatePhoneList(string name, string lastName, string eMail, bool status, int listId)
        {
            PhoneListService pls = new();
            PhoneList list = new()
            {
                EMail = eMail,
                LastName = lastName,
                Status = status,
                Name = name,
                ListId = listId

            };
            bool isUpdate = pls.ListUpdate(list);

            if (isUpdate)
            {
                return Json("Kisi Güncellendi");

            }
            else
            {
                return Json("Kisi Güncellenemedi");
            }
        }

        [HttpPost]
        public IActionResult ListDelete(int id)
        {
            PhoneListService phoneListService = new();
            var result = phoneListService.ListDelete(id);
            return Json("Kisi Silindi");
        }
    }
}
