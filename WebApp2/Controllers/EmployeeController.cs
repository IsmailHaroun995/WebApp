using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp2.ViewModel;

namespace WebApp2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee<EEmployee> empRepo;
        private readonly IEmployee<EDepartment> depRepo;

        public EmployeeController(IEmployee<EEmployee> EmpRepo,IEmployee<EDepartment> DepRepo)
        {
            empRepo = EmpRepo;
            depRepo = DepRepo;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var e = empRepo.List();
            return View(e);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var e = empRepo.Find(id);
            return View(e);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            var model = new EmployeeDepartmemtViewModel
            {
                Department = (List<EDepartment>)depRepo.List()
            };
            return View(model);
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeDepartmemtViewModel eE)
        {
            try
            {
                
                EEmployee e = new EEmployee
                {
                    Id = eE.Id,
                    FirstName = eE.FirstName,
                    LastName = eE.LastName,
                    Gender = eE.Gender,
                    Address = eE.Address,
                    Email = eE.Email,
                    Password = eE.Password
                
                };
                empRepo.Add(e);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var e = empRepo.Find(id);
            return View(e);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EEmployee e)
        {
            try
            {
                empRepo.Update(id,e);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var e = empRepo.Find(id);
            return View(e);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EEmployee e)
        {
            try
            {
                empRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
