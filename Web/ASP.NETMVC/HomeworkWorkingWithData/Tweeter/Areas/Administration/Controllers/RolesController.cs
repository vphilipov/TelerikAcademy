using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Tweeter.Controllers;
using Tweeter.Data;

namespace Tweeter.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class RolesController : BaseController
    {
        public RolesController()
            : base(new UowData())
        {
        }

        public RolesController(IUowData data)
            : base(data)
        {
        }

        // GET: /Administration/Roles/
        public ActionResult Index()
        {
            return View(this.Data.Roles.All().ToList());
        }

        // GET: /Administration/Roles/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = this.Data.Roles.GetById(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // GET: /Administration/Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Administration/Roles/Create
		// To protect from over posting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		// 
		// Example: public ActionResult Update([Bind(Include="ExampleProperty1,ExampleProperty2")] Model model)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Role role)
        {
            if (ModelState.IsValid)
            {
                this.Data.Roles.Add(role);
                this.Data.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(role);
        }

        // GET: /Administration/Roles/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = this.Data.Roles.GetById(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: /Administration/Roles/Edit/5
		// To protect from over posting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		// 
		// Example: public ActionResult Update([Bind(Include="ExampleProperty1,ExampleProperty2")] Model model)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Role role)
        {
            if (ModelState.IsValid)
            {
                this.Data.Roles.Update(role);
                this.Data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(role);
        }

        // GET: /Administration/Roles/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = this.Data.Roles.GetById(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: /Administration/Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Role role = this.Data.Roles.GetById(id);
            this.Data.Roles.Delete(role);
            this.Data.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            this.Data.Dispose();
            base.Dispose(disposing);
        }
    }
}
