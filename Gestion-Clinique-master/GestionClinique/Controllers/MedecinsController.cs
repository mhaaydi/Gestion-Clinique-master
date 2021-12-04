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
    public class MedecinsController : Controller
    {
        private DefaultConnectionEntities db = new DefaultConnectionEntities();

        // GET: Medecins
        public ActionResult Index()
        {
            var medecins = db.Medecins.Include(m => m.AspNetUser).Include(m => m.Patient).Include(m => m.Service);
            return View(medecins.ToList());
        }

        // GET: Medecins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medecin medecin = db.Medecins.Find(id);
            if (medecin == null)
            {
                return HttpNotFound();
            }
            return View(medecin);
        }

        // GET: Medecins/Create
        public ActionResult Create()
        {
            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser");
            ViewBag.IdService = new SelectList(db.Services, "Id", "Nom");
            return View();
        }

        // POST: Medecins/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdUser,IdPatient,IdService,Nom,Prenom,Genre,Adresse,Telephone,Email,Grade,Fonction,Specialite,DateNaissance,DateRecrutement")] Medecin medecin)
        {
            if (ModelState.IsValid)
            {
                db.Medecins.Add(medecin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email", medecin.IdUser);
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser", medecin.IdPatient);
            ViewBag.IdService = new SelectList(db.Services, "Id", "Nom", medecin.IdService);
            return View(medecin);
        }

        // GET: Medecins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medecin medecin = db.Medecins.Find(id);
            if (medecin == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email", medecin.IdUser);
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser", medecin.IdPatient);
            ViewBag.IdService = new SelectList(db.Services, "Id", "Nom", medecin.IdService);
            return View(medecin);
        }

        // POST: Medecins/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdUser,IdPatient,IdService,Nom,Prenom,Genre,Adresse,Telephone,Email,Grade,Fonction,Specialite,DateNaissance,DateRecrutement")] Medecin medecin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medecin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email", medecin.IdUser);
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser", medecin.IdPatient);
            ViewBag.IdService = new SelectList(db.Services, "Id", "Nom", medecin.IdService);
            return View(medecin);
        }

        // GET: Medecins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medecin medecin = db.Medecins.Find(id);
            if (medecin == null)
            {
                return HttpNotFound();
            }
            return View(medecin);
        }

        // POST: Medecins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Medecin medecin = db.Medecins.Find(id);
            db.Medecins.Remove(medecin);
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
