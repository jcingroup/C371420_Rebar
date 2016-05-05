
using System.Web.Mvc;


namespace DotWeb.Controllers
{
    public class WorksController : WebFrontController
    {
        public ActionResult Index()
        {
            return View("Works");
        }
    }
}