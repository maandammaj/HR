using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Controllers
{
    public class QualificationController : Controller
    {
        // GET: QualificationController
        public ActionResult IndexTypeQualification()
        {
            return View();
        }
    
        public ActionResult IndexSpecialties()
        {
            return View();
        }
        public ActionResult IndexSubSpecialties()
        {
            return View();
        }
        public ActionResult IndexSubQualification()
        {
            return View();
        }
        public ActionResult IndexEstimates()
        {
            return View();
        }   
        public ActionResult IndexEMPHASQUALIFICATIONS()
        {
            return View();
        }
        // GET: QualificationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QualificationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QualificationController/Create
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

        // GET: QualificationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QualificationController/Edit/5
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

        // GET: QualificationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QualificationController/Delete/5
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
