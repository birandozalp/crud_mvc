using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VoyagerYMVC.Areas.Management.Controllers
{
    [Authorize]
    public class ManagementPanelController : Controller
    {
        // GET: Management/ManagementPanel
        
        public ActionResult Index()
        {
            return View();
        }
    }
}