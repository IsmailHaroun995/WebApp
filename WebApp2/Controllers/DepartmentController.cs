using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IEmployee<EDepartment> depRepo;
        public DepartmentController(IEmployee<EDepartment> DepRepo)
        {
            depRepo = DepRepo;
        }
        // GET: DepartmentController
        public ActionResult Index()
        {
            var d = depRepo.List();
            return View(d);
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            var d = depRepo.Find(id);
            return View(d);
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EDepartment d)
        {
            try
            {
                depRepo.Add(d);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            var d = depRepo.Find(id);
            return View();
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EDepartment d)
        {
            try
            {
                depRepo.Update(id, d);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Delete/5
        public ActionResult Delete(int id)
        {
            var d = depRepo.Find(id);
           
            return View();
        }

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EDepartment d)
        {
            try
            {
                 depRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
