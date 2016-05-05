
using System.Web.Mvc;


namespace DotWeb.Controllers
{
    public class AboutUsController : WebFrontController
    {
        public ActionResult Index()
        {
            return View("AboutUs");
        }
    }
}
