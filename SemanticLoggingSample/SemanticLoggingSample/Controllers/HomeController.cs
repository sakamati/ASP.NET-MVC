using SemanticLogging.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SemanticLoggingSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult LogError()
        {
            SampleEventSource.Log.Failure("Error raised from LogError action method of Home controller.");
            return View();
        }

        public ActionResult LogInformation()
        {
            SampleEventSource.Log.Information("Information raised from LogInformation action method of Home controller.");
            return View();
        }
    }
}