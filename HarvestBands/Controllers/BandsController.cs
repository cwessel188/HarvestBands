using HarvestBands.Models;
using HarvestBands.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarvestBands.Controllers
{
    public class BandsController : Controller
    {
        // creates a generic repository
        private IBandService _bandService;

        // maps the generic repo to my EFRepository
        public BandsController(IBandService bandService)
        {
            _bandService = bandService;
        }

        // GET: Bands
        public ActionResult Index()
        {
            
            return View( _bandService.IndexList() );
        }

        // GET: Bands/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bands/Create
        [HttpPost]
        public ActionResult Create(Band Band)
        {
            if (ModelState.IsValid)
            {

            }

                return View();
            
        }

        // GET: Bands/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bands/Edit/5
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

        // GET: Bands/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bands/Delete/5
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
