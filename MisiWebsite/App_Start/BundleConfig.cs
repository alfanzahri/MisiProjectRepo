using System.Web;
using System.Web.Optimization;

namespace MisiWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //jquery for admin theme
            bundles.Add(new ScriptBundle("~/bundles/jsadmintheme").Include(
                       "~/Scripts/jquery-1.11.0.min.js",
                       "~/Scripts/jquery-migrate-1.2.1.min.js",
                       "~/Scripts/enquire.min.js",
                       "~/Scripts/jquery.scrollTo.js",
                       "~/Scripts/admin-theme.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //js for modernizr.min
            bundles.Add(new ScriptBundle("~/bundles/jsmodenzir").Include(
                        "~/Scripts/modernizr.min.js"));

            //js for modernzir.load
            bundles.Add(new ScriptBundle("~/bundles/jsmodenzirload").Include(
                        "~/Scripts/modernizr-loads.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"
                //"~/Scripts/respond.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Scripts bundles for kendo
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
            "~/Scripts/kendo/kendo.all.min.js",
                // "~/Scripts/kendo/kendo.timezones.min.js", // uncomment if using the Scheduler
            "~/Scripts/kendo/kendo.aspnetmvc.min.js"));

            //content css for kendo
            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
            "~/Content/kendo/kendo.common-bootstrap.min.css",
            "~/Content/kendo/kendo.bootstrap.min.css"));

            //content css for admin theme
            bundles.Add(new StyleBundle("~/Content/cssadmintheme").Include(
                       "~/Content/admin-theme.css",
                       "~/Content/font-awesome.min.css"));
        }
    }
}
