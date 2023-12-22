using Microsoft.AspNetCore.Mvc;
using PlaygroundDemo.Web.Controllers;

namespace PlaygroundDemo.Web.Public.Controllers
{
    public class AboutController : PlaygroundDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}