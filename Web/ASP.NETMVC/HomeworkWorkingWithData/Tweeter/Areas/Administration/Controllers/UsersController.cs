using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tweeter.Models;
using Tweeter.Data;
using Tweeter.Controllers;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Tweeter.Areas.Administration.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class UsersController : BaseController
    {
        private TweeterEntities db = new TweeterEntities();

        public UsersController()
            : base(new UowData())
        {
        }

        public UsersController(IUowData data)
            : base(data)
        {
        }

        // GET: /Administration/Users/
        public ActionResult Index()
        {
            return View(db.Tags.ToList());
        }

        // GET: /Administration/Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = db.Tags.Find(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            return View(tag);
        }

        // GET: /Administration/Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Administration/Users/Create
        // To protect from over posting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // 
        // Example: public ActionResult Update([Bind(Include="ExampleProperty1,ExampleProperty2")] Model model)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tag tag)
        {
            if (ModelState.IsValid)
            {
                db.Tags.Add(tag);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tag);
        }

        // GET: /Administration/Users/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser user = this.Data.Users.GetById(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            var roles = this.Data.Roles.All().Where(r => !r.UserRoles.Any(ur=> ur.UserId == id)).Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            });

            this.ViewBag.role = roles;

            return View(user);
        }

        // POST: /Administration/Users/Edit/5
        // To protect from over posting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // 
        // Example: public ActionResult Update([Bind(Include="ExampleProperty1,ExampleProperty2")] Model model)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ApplicationUser user, string role)
        {
            Role roleToAdd = this.Data.Roles.GetById(role);
            UserRole newEntry = new UserRole()
            {
                Role = roleToAdd,
                //RoleId = roleToAdd.Id,
                //User = user,
                //UserId = user.Id
            };
            user.Roles.Add(newEntry);

            if (ModelState.IsValid)
            {
                //db.Entry(user).State = EntityState.Modified;
                this.Data.Users.Update(user);
                this.Data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: /Administration/Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = db.Tags.Find(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            return View(tag);
        }

        // POST: /Administration/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tag tag = db.Tags.Find(id);
            db.Tags.Remove(tag);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
