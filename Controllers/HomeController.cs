using Microsoft.AspNetCore.Mvc;
using partyInvites06.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace partyInvites06.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = 16;
            ViewBag.GG = hour;
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RspvForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RspvForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
            
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
