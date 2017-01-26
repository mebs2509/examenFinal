using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Universidad.Context;
using Universidad.Entities;

namespace Universidad.MVC.Controllers
{
    public class AlumnoController : Controller
    {
        private UniversidadDbContext db = new UniversidadDbContext();

        // GET: Alumno
        public ActionResult Index()
        {
            var alumno = db.Alumno.Include(a => a.EstadoCivil).Include(a => a.Genero);
            return View(alumno.ToList());
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            ViewBag.EstadoCivilId = new SelectList(db.EstadoCivil, "Id", "Descripcion");
            ViewBag.GeneroId = new SelectList(db.Genero, "Id", "Descripcion");

            return View();
        }

        // POST: Alumno/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AlumnoId,Created,Codigo,Apellidos,Nombres,GeneroId,EstadoCivilId")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                alumno.Created = DateTime.Now;
                db.Alumno.Add(alumno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstadoCivilId = new SelectList(db.EstadoCivil, "Id", "Descripcion", alumno.EstadoCivilId);
            ViewBag.GeneroId = new SelectList(db.Genero, "Id", "Descripcion", alumno.GeneroId);
            return View(alumno);
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstadoCivilId = new SelectList(db.EstadoCivil, "Id", "Descripcion", alumno.EstadoCivilId);
            ViewBag.GeneroId = new SelectList(db.Genero, "Id", "Descripcion", alumno.GeneroId);
            return View(alumno);
        }

        // POST: Alumno/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlumnoId,Created,Codigo,Apellidos,Nombres,GeneroId,EstadoCivilId")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstadoCivilId = new SelectList(db.EstadoCivil, "Id", "Descripcion", alumno.EstadoCivilId);
            ViewBag.GeneroId = new SelectList(db.Genero, "Id", "Descripcion", alumno.GeneroId);
            return View(alumno);
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alumno alumno = db.Alumno.Find(id);
            db.Alumno.Remove(alumno);
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
