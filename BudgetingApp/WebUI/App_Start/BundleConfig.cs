using System.Web;
using System.Web.Optimization;

namespace WebUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Content/bootstrap/js/bootstrap.min.js",
                        "~/Content/js/jquery.easing.1.3.min.js",
                        "~/Content/js/jquery.sticky.js",
                        "~/Content/js/jquery.flexslider-min.js",
                        "~/Content/js/jquery.stellar.min.js",
                        "~/Content/js/jquery.mixitup.min.js",
                         "~/Content/js/jquery.counterup.min.js",
                        "~/Content/js/wow.min.js",
                        "~/Content/js/owl.carousel.min.js",
                        "~/Content/js/custom.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap/css/bootstrap.min.css",
                      "~/Content/css/style.css",
                      "~/Content/font-awesome-4.1.0/css/font-awesome.min.css",
                      "~/Content/css/flexslider.css",
                      "~/Content/css/animate.css",
                       "~/Content/css/owl.carousel.css",
                       "~/Content/css/owl.theme.css",
                       "~/Content/css/owl.theme.css"
                      ));
        }
    }
}
