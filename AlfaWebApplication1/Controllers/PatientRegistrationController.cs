using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace AlfaWebApplication1.Controllers
{
    public class PatientRegistrationController : Controller
    {

        //sqlconnection

        private SqlConnection con;

        //To Handle connection related activities

        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);

        }

        // GET: PatientRegistration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisterPatient()
        {

            return View();
        }
    }
}