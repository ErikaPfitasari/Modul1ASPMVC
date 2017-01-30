using System;
using System.Web.Mvc;
namespace LatihanDBLokal.Controller
{
    public class HomeController
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Welcome()
        {
            return View();
        }

        private ActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
