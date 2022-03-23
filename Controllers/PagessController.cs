using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Controllers
{
    public class PagessController : Controller
    {
        // GET: PagessController
        public ActionResult IndexFunctionalMovement()
        {
            return View();
        }    
 
        public ActionResult IndexCOURSES()
        {
            return View();
        }       
        public ActionResult IndexFUNCTIONALDATA()
        {
            return View();
        } 
        public ActionResult IndexFUNANCIALSTATEMENTS()
        {
            return View();
        }
        public ActionResult IndeREWARDS()
        {
            return View();
        }

        // GET: PagessController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PagessController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PagessController/Create
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

        // GET: PagessController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PagessController/Edit/5
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

        // GET: PagessController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PagessController/Delete/5
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
