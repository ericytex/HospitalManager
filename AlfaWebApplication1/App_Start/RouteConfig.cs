using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AlfaWebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //patient registration
            routes.MapRoute(
                name: "RegisterPatient",
                url: "PatientRegistration/registerpatient",
                defaults: new { controller = "PatientRegistration", action = "registerpatient", id = UrlParameter.Optional }
            );

            //outpatient Management
            routes.MapRoute(
                name: "OutPatientManagement",
                url: "OutpatientManagement/ActionOutpatient",
                defaults: new { controller = "OutpatientManagement", action = "ActionOutpatient", id = UrlParameter.Optional }
            );

            //Laboratory Management
            routes.MapRoute(
                name: "LaboratoryManagement",
                url: "LaboratoryManagement/ActionLaboratoryManagement",
                defaults: new { controller = "LaboratoryManagement", action = "ActionLaboratoryManagement", id = UrlParameter.Optional }
            );

            //Radiology Management
            routes.MapRoute(
                name: "Radiology Management",
                url: "RadiologyManagement/ActionRadiologyManagement",
                defaults: new { controller = "RadiologyManagement", action = "ActionRadiologyManagement", id = UrlParameter.Optional }
            );

            //Consultation Management
            routes.MapRoute(
                name: "Consultation Management",
                url: "ConsultationManagement/ActionConsultationManagement",
                defaults: new { controller = "ConsultationManagement", action = "ActionConsultationManagement", id = UrlParameter.Optional }
            );

            //Store Management
            routes.MapRoute(
                name: "Store Management",
                url: "StoreManagement/ActionStoreManagement",
                defaults: new { controller = "StoreManagement", action = "ActionStoreManagement", id = UrlParameter.Optional }
            );

            //Accounts Management
            routes.MapRoute(
                name: "Accounts Management",
                url: "AccountsManagement/ActionAccountsManagement",
                defaults: new { controller = "AccountsManagement", action = "ActionAccountsManagement", id = UrlParameter.Optional }
            );

            //Pharmacy Management
            routes.MapRoute(
                name: "Pharmacy Management",
                url: "PharmacyManagement/ActionPharmacyManagement",
                defaults: new { controller = "PharmacyManagement", action = "ActionPharmacyManagement", id = UrlParameter.Optional }
            );

            //InPatientBilling
            routes.MapRoute(
                name: "InPatientBilling",
                url: "InPatientBilling/ActionInPatientBilling",
                defaults: new { controller = "InPatientBilling", action = "ActionInPatientBilling", id = UrlParameter.Optional }
            );

            //InPatientManagement
            routes.MapRoute(
                name: "InPatientManagement",
                url: "InPatientManagement/ActionInPatientManagement",
                defaults: new { controller = "InPatientManagement", action = "ActionInPatientManagement", id = UrlParameter.Optional }
            );
            //Default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
