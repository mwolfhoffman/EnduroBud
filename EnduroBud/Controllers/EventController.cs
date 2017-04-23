using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EnduroBud.Controllers
{
    public class EventController : Controller
    {

        private EventContext _db;

        public EventController (EventContext db)
        {
            _db = db;
        }

        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
