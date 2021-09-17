using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3.Models;

namespace Project3.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            var contacts = new ContactViewModel();

            return View(contacts);
        }

        [HttpPost]
        public JsonResult Send(ContactViewModel contact)
        {
            if (ModelState.IsValid)
            {
                return Json("İşleminiz başarıyla tamamlanmıştır.");
            }
            else
            {
                if(contact.Name==null)
                {
                    return Json("Ad Soyad boş geçilemez");
                }

                if (contact.Age<0 || contact.Age>121)
                {
                    return Json("Yaş değeri 1-120 arasında olmalıdır.");
                }

                if (contact.selectedCity == null)
                {
                    return Json("Şehir boş geçilemez");
                }

                return Json("Hata");
            }

        }
    }
}
