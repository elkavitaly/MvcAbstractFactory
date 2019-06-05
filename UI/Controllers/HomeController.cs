using System.Web.Mvc;
using BLL.Infrastructure;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private IRepositoryFactory _factory;

        public HomeController()
        {
            _factory = Initializer.Initialize();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}