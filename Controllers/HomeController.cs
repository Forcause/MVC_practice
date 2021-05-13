using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication.Models;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using SelectList = Microsoft.AspNetCore.Mvc.Rendering.SelectList;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private pract7Context db = new pract7Context();
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var autos = db.Autos.Include(a => a.MarkNavigation);
            return View(autos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return Error();
            }

            Auto auto = db.Autos.Find(id);
            if (auto != null)
            {
                db.Autos.Remove(auto);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Error();
            }

            Auto auto = db.Autos.Find(id);
            if (auto != null)
            {
                SelectList corps = new SelectList(db.Corps, "Mark", "Mark", auto.MarkNavigation);
                ViewBag.Corps = corps;
                return View(auto);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Auto auto)
        {
            db.Entry(auto).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            SelectList corps = new SelectList(db.Corps, "Mark", "Mark");
            ViewBag.Corps = corps;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Auto auto)
        {
            try
            {
                db.Autos.Add(auto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Details(int id = 0)
        {
            Auto auto = db.Autos.Find(id);
            auto = db.Autos.Include(a => a.MarkNavigation).FirstOrDefault(a => a.Id == id);
            if (auto == null)
            {
                return Error();
            }

            return View(auto);
        }

        [HttpGet]
        public IActionResult CreateCorp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCorp(Corps corp)
        {
            try
            {
                db.Corps.Add(corp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult ShowCorps()
        {
            var corps = db.Corps.Include(a => a.Autos);
            return View(corps);
        }
        
        [HttpGet]
        public IActionResult EditCorp(string mark)
        {
            if (mark == null)
            {
                return Error();
            }

            Corps corp = db.Corps.Find(mark);
            if (corp != null)
            {
                return View(corp);
            }

            return RedirectToAction("ShowCorps");
        }

        [HttpPost]
        public IActionResult EditCorp(Corps corp)
        {
            db.Entry(corp).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ShowCorps");
        }

        public IActionResult DeleteCorp(string mark)
        {
            if (mark == null)
            {
                return Error();
            }

            Corps corp = db.Corps.Find(mark);
            
            if (corp != null)
            {
                db.Corps.Remove(corp);
                db.SaveChanges();
            }

            return RedirectToAction("ShowCorps");
        }
    }
}