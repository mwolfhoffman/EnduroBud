using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnduroBud.Models;


namespace EnduroBud.Controllers
{
    public class EventController : Controller
    {

        private EventContext _db;

        public EventController(EventContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            var events = _db.Events.ToList();
            return View(events);
        }

        [HttpPost]
        public string Events(Event evt)
        {
            if (ModelState.IsValid)
            {
                _db.Events.Add(evt);
                _db.SaveChanges();
            }
            return "Posted!";
        }
    }
}
