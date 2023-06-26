using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC008.Models;
namespace WebMVC008.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student stdObj)
        {
            StddbEntities _db = new StddbEntities();
            _db.Students.Add(new Student {STDNAME = stdObj.STDNAME,SEM= stdObj.SEM,BATCH =stdObj.BATCH });
            _db.SaveChanges();
            return View();
        }
        public ActionResult ShowAllData()
        {
            StddbEntities _db = new StddbEntities();
            var _stdList = _db.Students.ToList();
            return View(_stdList);
        }
        public ActionResult Edit(int id)
        {
            StddbEntities _db = new StddbEntities();
           var Stud=  _db.Students.Where(x => x.ID == id).Single();
            return View(Stud);
        }

        [HttpPost]
        public ActionResult Edit(Student std )
        {
            StddbEntities _db = new StddbEntities();
            var Stud = _db.Students.Where(x => x.ID == std.ID).Single();
            Stud.STDNAME = std.STDNAME;
            Stud.BATCH = std.BATCH;
            Stud.SEM = std.SEM;
            _db.SaveChanges();
            return RedirectToAction("ShowAllData");
        }

        public ActionResult Delete(int id)
        {
            StddbEntities _db = new StddbEntities();
            var Stud = _db.Students.Where(x => x.ID == id).Single();
            _db.Students.Remove(Stud);
            _db.SaveChanges();
            
            return RedirectToAction("ShowAllData");
        }
    }
}