﻿using MDR.Web.UI.Models;
using System.Web.Mvc;

namespace MDR.Web.UI.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            var message = new ContactMessage();
            return View(message);
        }

        [HttpPost]
        public JsonResult SendMessage(ContactMessage message)
        {
            if (ModelState.IsValid)
            {
                // Process form submit
            }
            return Json("Error");
        }
    }
}