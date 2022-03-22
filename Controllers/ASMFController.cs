using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Controllers
{
    public class ASMFController : Controller
    {
        // GET: ASMFController1
        public ActionResult indexSectors()
        {
            return View();
        }
        public ActionResult indexManagemt()
        {
            return View();
        }
        public ActionResult indexManagemtFRAY()
        {
            return View();
        }

        // GET: ASMFController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ASMFController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASMFController1/Create
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

        // GET: ASMFController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ASMFController1/Edit/5
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

        // GET: ASMFController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ASMFController1/Delete/5
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
