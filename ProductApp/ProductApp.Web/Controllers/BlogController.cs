using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductModels.Lib;

namespace ProductApp.Web.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public ActionResult Index()
        {
            // hent data fra eks. db eller API eller...
            //List<Student> students = new List<Student>();
            //return View(students);

            //opret en web client
            WebClient wc = new WebClient();
            //hent data fra API (Kommer som json)
            var json = wc.DownloadString("https://localhost:44310/api/product");
            //deserialisere det rå data til List<Student>
            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            var result = JsonSerializer.Deserialize<List<Student>>(json, options);
            //Returnere
            return View(result);

            /*
            // https://www.tutorialsteacher.com/mvc/integrate-controller-view-model 
            List<Student> students = new List<Student>
            {
                new Student() { Id = 1, FirstName = "Alan", LastName = "Super", Email = "Alan@super.dk", CPR = 12131411 },
                new Student() { Id = 10, FirstName = "Alan2", LastName = "Super1", Email = "Alan@super2.dk", CPR = 12131411 }
            };

            return View(students);
            */
        }

        // GET: BlogController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
