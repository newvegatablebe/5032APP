using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _5032APP1.Models;

namespace _5032APP1.Controllers
{
    public class PatiencesController : Controller
    {
        private Patient_Model db = new Patient_Model();

        // GET: Patiences
        public ActionResult Index()
        {
            return View(db.Patiences.ToList());
        }

        // GET: Patiences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patience patience = db.Patiences.Find(id);
            if (patience == null)
            {
                return HttpNotFound();
            }
            return View(patience);
        }

        // GET: Patiences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patiences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Doctor_name,Patience_name,Patience_age,Patiene_service,date")] Patience patience)
        {
            if (ModelState.IsValid)
            {
                db.Patiences.Add(patience);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patience);
        }

        // GET: Patiences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patience patience = db.Patiences.Find(id);
            if (patience == null)
            {
                return HttpNotFound();
            }
            return View(patience);
        }

        // POST: Patiences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Doctor_name,Patience_name,Patience_age,Patiene_service,date")] Patience patience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patience);
        }

        // GET: Patiences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patience patience = db.Patiences.Find(id);
            if (patience == null)
            {
                return HttpNotFound();
            }
            return View(patience);
        }

        // POST: Patiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patience patience = db.Patiences.Find(id);
            db.Patiences.Remove(patience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
