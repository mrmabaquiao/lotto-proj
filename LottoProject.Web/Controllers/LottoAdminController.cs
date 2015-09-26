using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LottoProject.Domain;

namespace LottoProject.Web.Controllers
{
    public class LottoAdminController : Controller
    {
        private ILottoDataSource _db;

        public LottoAdminController(ILottoDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allDraws = _db.Draws;
            return View(allDraws);
        }

        //
        // GET: /LottoAdmin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /LottoAdmin/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LottoAdmin/Create

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

        //
        // GET: /LottoAdmin/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /LottoAdmin/Edit/5

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

        //
        // GET: /LottoAdmin/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /LottoAdmin/Delete/5

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
