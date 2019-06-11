using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoyagerYBusiness;
using VoyagerYMVC.Areas.Management.ViewModels;

namespace VoyagerYMVC.Areas.Management.Controllers
{
    [Authorize]
    public class BusManagementController : Controller
    {
       
        // GET: Management/BusManagement
       
        public ActionResult Index()
        {
            return View(Startup.webApp.busService.GetAll());
        }

        public ActionResult Delete(int id)
        {
            var result = Startup.webApp.busService.GetAll().SingleOrDefault(x => x.Id == id);
            Startup.webApp.busService.Remove(result);
            return RedirectToAction("Index");
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public ActionResult Add()
        {
            var busVM = new BusVM()
            {
               
                TypeList = Startup.webApp.busTypeService.GetAll()
            };

            return View(busVM);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public  ActionResult Add(Bus bus)
        {
            Startup.webApp.busService.Add(bus);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Bus bus = Startup.webApp.busService.GetAll().SingleOrDefault(x => x.Id == id);
            BusVM busVM = new BusVM();
            busVM.Bus = bus;
            busVM.TypeList = Startup.webApp.busTypeService.GetAll();

            return View(busVM);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Edit(Bus bus)
        {
            Startup.webApp.busService.Update(bus);
            return RedirectToAction("Index");
        }
    }
}