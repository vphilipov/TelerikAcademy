using System.Web.Mvc;
using Tweeter.Data;

namespace Tweeter.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(IUowData data)
        {
            this.Data = data;
        }

        protected IUowData Data { get; set; }
    }
}