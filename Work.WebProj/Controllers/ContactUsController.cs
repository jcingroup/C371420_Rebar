
using System.Web.Mvc;


namespace DotWeb.Controllers
{
    public class ContactUsController : WebFrontController
    {
        public ActionResult Index()
        {
            return View("ContactUs");
        }
    }
}