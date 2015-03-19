using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectRUP_1.Models;

namespace ProjectRUP_1.Controllers
{
    public class ExamSubscriptionsController : Controller
    {
        private HUInspectorEntities1 db = new HUInspectorEntities1();

        // GET: ExamSubscriptions
        public ActionResult Index()
        {
            var examSubscription = db.ExamSubscription.Include(e => e.Exam).Include(e => e.User);
            return View(examSubscription.ToList());
        }

        // GET: ExamSubscriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamSubscription examSubscription = db.ExamSubscription.Find(id);
            if (examSubscription == null)
            {
                return HttpNotFound();
            }
            return View(examSubscription);
        }

        // GET: ExamSubscriptions/Create
        public ActionResult Create()
        {
            ViewBag.ExamId = new SelectList(db.Exam, "Id", "Name");
            ViewBag.UserId = new SelectList(db.User, "Id", "FirstName");
            return View();
        }

        // POST: ExamSubscriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,ExamId,Id,Result,ExamClassroomId,Week,IsNA")] ExamSubscription examSubscription)
        {
            if (ModelState.IsValid)
            {
                db.ExamSubscription.Add(examSubscription);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ExamId = new SelectList(db.Exam, "Id", "Name", examSubscription.ExamId);
            ViewBag.UserId = new SelectList(db.User, "Id", "FirstName", examSubscription.UserId);
            return View(examSubscription);
        }

        // GET: ExamSubscriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamSubscription examSubscription = db.ExamSubscription.Find(id);
            if (examSubscription == null)
            {
                return HttpNotFound();
            }
            ViewBag.ExamId = new SelectList(db.Exam, "Id", "Name", examSubscription.ExamId);
            ViewBag.UserId = new SelectList(db.User, "Id", "FirstName", examSubscription.UserId);
            return View(examSubscription);
        }

        // POST: ExamSubscriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,ExamId,Id,Result,ExamClassroomId,Week,IsNA")] ExamSubscription examSubscription)
        {
            if (ModelState.IsValid)
            {
                db.Entry(examSubscription).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ExamId = new SelectList(db.Exam, "Id", "Name", examSubscription.ExamId);
            ViewBag.UserId = new SelectList(db.User, "Id", "FirstName", examSubscription.UserId);
            return View(examSubscription);
        }

        // GET: ExamSubscriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamSubscription examSubscription = db.ExamSubscription.Find(id);
            if (examSubscription == null)
            {
                return HttpNotFound();
            }
            return View(examSubscription);
        }

        // POST: ExamSubscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExamSubscription examSubscription = db.ExamSubscription.Find(id);
            db.ExamSubscription.Remove(examSubscription);
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
