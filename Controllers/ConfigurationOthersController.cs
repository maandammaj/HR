using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Controllers
{
    public class ConfigurationOthersController : Controller
    {
        // GET: ConfigurationOthersController1
        public ActionResult IndexSCREENS()
        {
            return View();
        }  
        public ActionResult IndexDISCIPLINE()
        {
            return View();//الاستقطاعات
        } 
        public ActionResult IndexDUES()
        {
            return View();//الاستحقاقات
        }  
        public ActionResult IndexALLOWANCE()
        {
            return View();//البدلات
        }   
        public ActionResult IndexABSENCES()
        {
            return View();//
        }

        // GET: ConfigurationOthersController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConfigurationOthersController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigurationOthersController1/Create
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

        // GET: ConfigurationOthersController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConfigurationOthersController1/Edit/5
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

        // GET: ConfigurationOthersController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConfigurationOthersController1/Delete/5
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
