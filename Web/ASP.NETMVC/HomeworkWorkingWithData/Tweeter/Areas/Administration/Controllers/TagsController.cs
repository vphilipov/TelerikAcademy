using System.Linq;
using System.Net;
using System.Web.Mvc;
using Tweeter.Controllers;
using Tweeter.Data;
using Tweeter.Models;

namespace Tweeter.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class TagsController : BaseController
    {
        //private TweeterEntities db = new TweeterEntities();

        public TagsController()
            : base(new UowData())
        {
        }

        public TagsController(IUowData data)
            : base(data)
        {
        }

        // GET: /LoggedUsers/Tags/
        public ActionResult Index()
        {
            return View(this.Data.Tags.All().ToList());
        }

        // GET: /LoggedUsers/Tags/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = this.Data.Tags.GetById(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            return View(tag);
        }

        // GET: /LoggedUsers/Tags/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /LoggedUsers/Tags/Create
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
                this.Data.Tags.Add(tag);
                this.Data.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tag);
        }

        // GET: /LoggedUsers/Tags/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = this.Data.Tags.GetById(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            return View(tag);
        }

        // POST: /LoggedUsers/Tags/Edit/5
		// To protect from over posting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		// 
		// Example: public ActionResult Update([Bind(Include="ExampleProperty1,ExampleProperty2")] Model model)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tag tag)
        {
            if (ModelState.IsValid)
            {
                this.Data.Tags.Update(tag);
                //db.Entry(tag).State = EntityState.Modified;
                this.Data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tag);
        }

        // GET: /LoggedUsers/Tags/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = this.Data.Tags.GetById(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            return View(tag);
        }

        // POST: /LoggedUsers/Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tag tag = this.Data.Tags.GetById(id);
            this.Data.Tags.Delete(tag);
            //db.Tags.Remove(tag);
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
