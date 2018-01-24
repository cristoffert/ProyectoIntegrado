using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoIntegrado.Controllers
{
    public class AnalisisController : Controller
    {
        // GET: Analisis
        public ActionResult Index()
        {
            return View();
        }

        // GET: Analisis/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Analisis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Analisis/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Analisis/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Analisis/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Analisis/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Analisis/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
