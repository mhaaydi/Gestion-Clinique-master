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
    public class LaboratoiresController : Controller
    {
        private DefaultConnectionEntities db = new DefaultConnectionEntities();

        // GET: Laboratoires
        public ActionResult Index()
        {
            var laboratoires = db.Laboratoires.Include(l => l.Examan).Include(l => l.Patient);
            return View(laboratoires.ToList());
        }

        // GET: Laboratoires/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laboratoire laboratoire = db.Laboratoires.Find(id);
            if (laboratoire == null)
            {
                return HttpNotFound();
            }
            return View(laboratoire);
        }

        // GET: Laboratoires/Create
        public ActionResult Create()
        {
            ViewBag.IdExamen = new SelectList(db.Examen, "Id", "TypeExamen");
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser");
            return View();
        }

        // POST: Laboratoires/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdPatient,IdExamen,Observation,DateAnalyse")] Laboratoire laboratoire)
        {
            if (ModelState.IsValid)
            {
                db.Laboratoires.Add(laboratoire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdExamen = new SelectList(db.Examen, "Id", "TypeExamen", laboratoire.IdExamen);
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser", laboratoire.IdPatient);
            return View(laboratoire);
        }

        // GET: Laboratoires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laboratoire laboratoire = db.Laboratoires.Find(id);
            if (laboratoire == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdExamen = new SelectList(db.Examen, "Id", "TypeExamen", laboratoire.IdExamen);
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser", laboratoire.IdPatient);
            return View(laboratoire);
        }

        // POST: Laboratoires/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdPatient,IdExamen,Observation,DateAnalyse")] Laboratoire laboratoire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laboratoire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdExamen = new SelectList(db.Examen, "Id", "TypeExamen", laboratoire.IdExamen);
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser", laboratoire.IdPatient);
            return View(laboratoire);
        }

        // GET: Laboratoires/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laboratoire laboratoire = db.Laboratoires.Find(id);
            if (laboratoire == null)
            {
                return HttpNotFound();
            }
            return View(laboratoire);
        }

        // POST: Laboratoires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Laboratoire laboratoire = db.Laboratoires.Find(id);
            db.Laboratoires.Remove(laboratoire);
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
