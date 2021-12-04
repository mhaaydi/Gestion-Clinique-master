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
    public class TraitementsController : Controller
    {
        private DefaultConnectionEntities db = new DefaultConnectionEntities();

        // GET: Traitements
        public ActionResult Index()
        {
            var traitements = db.Traitements.Include(t => t.Maladie).Include(t => t.Medecin);
            return View(traitements.ToList());
        }

        // GET: Traitements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Traitement traitement = db.Traitements.Find(id);
            if (traitement == null)
            {
                return HttpNotFound();
            }
            return View(traitement);
        }

        // GET: Traitements/Create
        public ActionResult Create()
        {
            ViewBag.IdMaladie = new SelectList(db.Maladies, "Id", "Famille");
            ViewBag.IdMedecin = new SelectList(db.Medecins, "Id", "IdUser");
            return View();
        }

        // POST: Traitements/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdMedecin,IdMaladie,DateDebut,DateFin,EtatFinal")] Traitement traitement)
        {
            if (ModelState.IsValid)
            {
                db.Traitements.Add(traitement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMaladie = new SelectList(db.Maladies, "Id", "Famille", traitement.IdMaladie);
            ViewBag.IdMedecin = new SelectList(db.Medecins, "Id", "IdUser", traitement.IdMedecin);
            return View(traitement);
        }

        // GET: Traitements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Traitement traitement = db.Traitements.Find(id);
            if (traitement == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMaladie = new SelectList(db.Maladies, "Id", "Famille", traitement.IdMaladie);
            ViewBag.IdMedecin = new SelectList(db.Medecins, "Id", "IdUser", traitement.IdMedecin);
            return View(traitement);
        }

        // POST: Traitements/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdMedecin,IdMaladie,DateDebut,DateFin,EtatFinal")] Traitement traitement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(traitement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMaladie = new SelectList(db.Maladies, "Id", "Famille", traitement.IdMaladie);
            ViewBag.IdMedecin = new SelectList(db.Medecins, "Id", "IdUser", traitement.IdMedecin);
            return View(traitement);
        }

        // GET: Traitements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Traitement traitement = db.Traitements.Find(id);
            if (traitement == null)
            {
                return HttpNotFound();
            }
            return View(traitement);
        }

        // POST: Traitements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Traitement traitement = db.Traitements.Find(id);
            db.Traitements.Remove(traitement);
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
