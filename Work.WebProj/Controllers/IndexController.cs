using System.Web.Mvc;
using ProcCore.Business.DB0;
using System.Collections.Generic;
using System.Linq;

namespace DotWeb.Controllers
{
    public class IndexController : WebFrontController
    {
        public ActionResult Index()
        {
            ViewBag.IsFirstPage = true;
            return View();
        }
    }

}
