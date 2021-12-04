using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestionClinique;

namespace GestionClinique.Controllers
{
    public class MaladiesController : Controller
    {
        private DefaultConnectionEntities db = new DefaultConnectionEntities();

        // GET: Maladies
        public ActionResult Index()
        {
            return View(db.Maladies.ToList());
        }

        // GET: Maladies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maladie maladie = db.Maladies.Find(id);
            if (maladie == null)
            {
                return HttpNotFound();
            }
            return View(maladie);
        }

        // GET: Maladies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maladies/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Famille,SousFamille,Designation,Prix")] Maladie maladie)
        {
            if (ModelState.IsValid)
            {
                db.Maladies.Add(maladie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maladie);
        }

        // GET: Maladies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maladie maladie = db.Maladies.Find(id);
            if (maladie == null)
            {
                return HttpNotFound();
            }
            return View(maladie);
        }

        // POST: Maladies/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Famille,SousFamille,Designation,Prix")] Maladie maladie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maladie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maladie);
        }

        // GET: Maladies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maladie maladie = db.Maladies.Find(id);
            if (maladie == null)
            {
                return HttpNotFound();
            }
            return View(maladie);
        }

        // POST: Maladies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Maladie maladie = db.Maladies.Find(id);
            db.Maladies.Remove(maladie);
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
