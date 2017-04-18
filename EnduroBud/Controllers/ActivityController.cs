using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnduroBud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EnduroBud.Controllers
{
    public class ActivityController : Controller
    {
        private ActivityContext _db;

        public ActivityController(ActivityContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Progress()
        {
            var activities = _db.Activities.ToList();
            return View(activities);
        }

        [HttpPost]
        public IActionResult Create(Activity activity)
        {
            if (ModelState.IsValid)
            {
                _db.Activities.Add(activity);
                _db.SaveChanges();
                return RedirectToAction("Progress");


            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveActivity(long activityId)
        {
            var activity = _db.Activities.Find(activityId);
            _db.Activities.Remove(activity);
            _db.SaveChanges();
            return Redirect("Progress");
        }

        [HttpGet("/edit/{id}")]
        public IActionResult EditActivity(long id)
        {
            var activity = _db.Activities.Find(id);

            return View(activity);
        }

        //PUT request isn't working with Razor right now, will change this Post to Put later. 
        [HttpPost("edit/{id}")]
        public IActionResult Edit(long id, Activity act)
        {

            var activity = _db.Activities.Find(id);
            _db.Entry(activity).CurrentValues.SetValues(act);
            _db.SaveChanges();
            return RedirectToAction("Progress");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
