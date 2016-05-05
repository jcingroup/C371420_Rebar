
using System.Web.Mvc;


namespace DotWeb.Controllers
{
    public class ServiceController : WebFrontController
    {
        public ActionResult Index()
        {
            return View("Service");
        }
    }
}