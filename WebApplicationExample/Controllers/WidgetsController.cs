using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConfigR;
using WebApplicationExample.Models;

namespace WebApplicationExample.Controllers
{
    public class WidgetsController : Controller
    {
        public ActionResult Index()
        {
            // Grab your widgets from the Configuration
            var widgets = Config.Global.Get<IEnumerable<Widget>>();

            // Pass the widgets to the View
            return View(widgets);
        }
    }
}