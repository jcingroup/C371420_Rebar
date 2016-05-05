
using System.Web.Mvc;


namespace DotWeb.Controllers
{
    public class ProductsController : WebFrontController
    {
        public ActionResult Index()
        {
            return View("Products");
        }
        public ActionResult p2()
        {
            return View("Products2");
        }
        public ActionResult p3()
        {
            return View("Products3");
        }
        public ActionResult p4()
        {
            return View("Products4");
        }
        public ActionResult p5()
        {
            return View("Products5");
        }
    }
}
