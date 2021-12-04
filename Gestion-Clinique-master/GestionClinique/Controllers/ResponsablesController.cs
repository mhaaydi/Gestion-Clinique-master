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
    public class ResponsablesController : Controller
    {
        private DefaultConnectionEntities db = new DefaultConnectionEntities();

        // GET: Responsables
        public ActionResult Index()
        {
            var responsables = db.Responsables.Include(r => r.AspNetUser).Include(r => r.Medecin).Include(r => r.Patient);
            return View(responsables.ToList());
        }

        // GET: Responsables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responsable responsable = db.Responsables.Find(id);
            if (responsable == null)
            {
                return HttpNotFound();
            }
            return View(responsable);
        }

        // GET: Responsables/Create
        public ActionResult Create()
        {
            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.IdPatient = new SelectList(db.Medecins, "Id", "IdUser");
            ViewBag.IdMedecin = new SelectList(db.Patients, "Id", "IdUser");
            return View();
        }

        // POST: Responsables/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdUser,IdPatient,IdMedecin,TypeConsultation,Observation,DateConsultation,Frais")] Responsable responsable)
        {
            if (ModelState.IsValid)
            {
                db.Responsables.Add(responsable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email", responsable.IdUser);
            ViewBag.IdPatient = new SelectList(db.Medecins, "Id", "IdUser", responsable.IdPatient);
            ViewBag.IdMedecin = new SelectList(db.Patients, "Id", "IdUser", responsable.IdMedecin);
            return View(responsable);
        }

        // GET: Responsables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responsable responsable = db.Responsables.Find(id);
            if (responsable == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email", responsable.IdUser);
            ViewBag.IdPatient = new SelectList(db.Medecins, "Id", "IdUser", responsable.IdPatient);
            ViewBag.IdMedecin = new SelectList(db.Patients, "Id", "IdUser", responsable.IdMedecin);
            return View(responsable);
        }

        // POST: Responsables/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdUser,IdPatient,IdMedecin,TypeConsultation,Observation,DateConsultation,Frais")] Responsable responsable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(responsable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email", responsable.IdUser);
            ViewBag.IdPatient = new SelectList(db.Medecins, "Id", "IdUser", responsable.IdPatient);
            ViewBag.IdMedecin = new SelectList(db.Patients, "Id", "IdUser", responsable.IdMedecin);
            return View(responsable);
        }

        // GET: Responsables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responsable responsable = db.Responsables.Find(id);
            if (responsable == null)
            {
                return HttpNotFound();
            }
            return View(responsable);
        }

        // POST: Responsables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Responsable responsable = db.Responsables.Find(id);
            db.Responsables.Remove(responsable);
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
