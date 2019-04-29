using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlfaWebApplication1.Controllers
{
    public class PatientRegistrationController : Controller
    {
        // GET: PatientRegistration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisterPatient()
        {
            ViewBag.Message = "Successfull Test";
            return View();
        }
    }
}