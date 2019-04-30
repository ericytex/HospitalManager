﻿using System.Web;
using System.Web.Optimization;

namespace AlfaWebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/admin-lte/css/AdminLTE.css",
                      "~/admin-lte/css/skins/skin-blue.css",
                      "~/admin-lte/plugins/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                      "~/admin-lte/bower_components/select2/dist/css/select2.min.css",
                      "~/admin-lte/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css"));

            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
                     "~/admin-lte/js/adminlte.js",
                     "~/admin-lte/plugins/fastclick/fastclick.js",
                     "~/admin-lte/plugins/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                     "~/admin-lte/bower_components/select2/dist/js/select2.full.min.js",
                     "~/admin-lte/bower_components/bootstrap-datepicker/dist/js/bootstrap - datepicker.min.js"));
            ;
        }
    }
}