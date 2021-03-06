﻿namespace MV.CV.Web
{
    using System.Web.Optimization;

    public static class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jQueryUi/jquery-ui.js",
                "~/Scripts/jQueryUi/mindmup-editable-table.js",
                "~/Scripts/site-scripts/create-cv.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/styles.css",
                      "~/Content/bootstrap-table.css"));

            bundles.Add(new StyleBundle("~/jQueryUi").Include(
                "~/Scripts/jQueryUi/jquery-ui.css",
                "~/Scripts/jQueryUi/jquery-ui.structure.css",
                "~/Scripts/jQueryUi/jquery-ui.theme.css"));

            // Theme bundles.
            bundles.Add(new ScriptBundle("~/themes/freelancer-scripts").Include(
                "~/Scripts/freelancer-theme-scripts/classie.js",
                "~/Scripts/freelancer-theme-scripts/cbpAnimatedHeader.js",
                "~/Scripts/freelancer-theme-scripts/jqBootstrapValidation.js",
                "~/Scripts/freelancer-theme-scripts/contact_me.js",
                "~/Scripts/freelancer-theme-scripts/freelancer.js"));

            bundles.Add(new StyleBundle("~/freelancer-styles").Include(
                "~/Content/freelancer-theme-css/bootstrap.min.css",
                "~/Content/freelancer-theme-css/freelancer.css",
                "~/Content/font-awesome/css/font-awesome.min.css"));
        }
    }
}
