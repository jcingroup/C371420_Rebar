
using System.Web.Mvc;


namespace DotWeb.Controllers
{
    public class FactoryController : WebFrontController
    {
        public ActionResult Index()
        {
            return View("Factory");
        }
    }
}