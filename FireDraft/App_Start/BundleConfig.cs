using System.Web;
using System.Web.Optimization;

namespace FireDraft
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bootstrap/js").Include(
                "~/js/jquery-{version}.js",
                "~/bootstrap/js/bootstrap.js"));
                        
                       // "~/js/endless/endless_dashboard.js",
                        //"~/js/endless/endless.js"));

            bundles.Add(new ScriptBundle("~/libraries").Include(
                        "~/js/parsley.js",
                        //"~/js/jquery.flot.js",
                        "~/js/rapheal.js",
                        "~/js/morris.js",
                        "~/js/jquery.colorbox.js",
                        "~/js/jquery.sparkline.js",
                        "~/js/jquery.popupoverlay.js",
                        "~/js/jquery.slimscroll.js",
                        "~/js/modernizr-*",
                        "~/js/jquery.cookie.js"));

            bundles.Add(new ScriptBundle("~/js/datatables").Include(
                "~/js/jquery.dataTables-{version}.js",
                "~/js/TableTools.js",
                "~/js/dataTables.editor.js",
                "~/js/dataTables.bootstrap.js",
                "~/js/dataTables.editor.bootstrap.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                    "~/bootstrap/css/bootstrap.css",
                    "~/css/font-awesome.css",
                    "~/css/pace.css",
                    "~/css/colorbox/colorbox.css",
                    "~/css/morris.css",
                    "~/css/endless.css",
                    "~/css/endless-skin.css"
                ));

            bundles.Add(new StyleBundle("~/css/datatables").
                Include(
                "~/css/TableTools.css"));
        }
    }
}