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
    public class HospitalisationsController : Controller
    {
        private DefaultConnectionEntities db = new DefaultConnectionEntities();

        // GET: Hospitalisations
        public ActionResult Index()
        {
            var hospitalisations = db.Hospitalisations.Include(h => h.AspNetUser).Include(h => h.Chambre).Include(h => h.Patient);
            return View(hospitalisations.ToList());
        }

        // GET: Hospitalisations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospitalisation hospitalisation = db.Hospitalisations.Find(id);
            if (hospitalisation == null)
            {
                return HttpNotFound();
            }
            return View(hospitalisation);
        }

        // GET: Hospitalisations/Create
        public ActionResult Create()
        {
            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.IdChambre = new SelectList(db.Chambres, "Id", "Localisation");
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser");
            return View();
        }

        // POST: Hospitalisations/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdUser,IdPatient,IdChambre,TypeConsultation,Observation,DateArrivee,DateDepart,Frais")] Hospitalisation hospitalisation)
        {
            if (ModelState.IsValid)
            {
                db.Hospitalisations.Add(hospitalisation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email", hospitalisation.IdUser);
            ViewBag.IdChambre = new SelectList(db.Chambres, "Id", "Localisation", hospitalisation.IdChambre);
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser", hospitalisation.IdPatient);
            return View(hospitalisation);
        }

        // GET: Hospitalisations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospitalisation hospitalisation = db.Hospitalisations.Find(id);
            if (hospitalisation == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email", hospitalisation.IdUser);
            ViewBag.IdChambre = new SelectList(db.Chambres, "Id", "Localisation", hospitalisation.IdChambre);
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser", hospitalisation.IdPatient);
            return View(hospitalisation);
        }

        // POST: Hospitalisations/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdUser,IdPatient,IdChambre,TypeConsultation,Observation,DateArrivee,DateDepart,Frais")] Hospitalisation hospitalisation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospitalisation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdUser = new SelectList(db.AspNetUsers, "Id", "Email", hospitalisation.IdUser);
            ViewBag.IdChambre = new SelectList(db.Chambres, "Id", "Localisation", hospitalisation.IdChambre);
            ViewBag.IdPatient = new SelectList(db.Patients, "Id", "IdUser", hospitalisation.IdPatient);
            return View(hospitalisation);
        }

        // GET: Hospitalisations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospitalisation hospitalisation = db.Hospitalisations.Find(id);
            if (hospitalisation == null)
            {
                return HttpNotFound();
            }
            return View(hospitalisation);
        }

        // POST: Hospitalisations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hospitalisation hospitalisation = db.Hospitalisations.Find(id);
            db.Hospitalisations.Remove(hospitalisation);
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
