using Microsoft.AspNetCore.Mvc;
using PlaygroundDemo.Web.Controllers;

namespace PlaygroundDemo.Web.Public.Controllers
{
    public class HomeController : PlaygroundDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}