using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public PartialViewResult Iniciar()
        {
            return PartialView("_partial");
        }
    }
}