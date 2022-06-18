using System.Web;
using System.Web.Optimization;

namespace Practica.EF.Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/MyCustomModal.css"));


            #region My bundles
            bundles.Add(new ScriptBundle("~/Pages/CustomerList").Include(
                    "~/Scripts/Pages/CustomersList.js"));

            bundles.Add(new ScriptBundle("~/Pages/ShippersList").Include(
                "~/Scripts/Pages/ShippersList.js"));

            bundles.Add(new ScriptBundle("~/bundles/MyCustomModal").Include(
                    "~/Scripts/MyCustomModal.js"));

            bundles.Add(new StyleBundle("~/Styles/Customers")
                .Include("~/Content/Customers.css"));

            bundles.Add(new StyleBundle("~/Styles/Shippers")
                .Include("~/Content/Shippers.css"));

            #endregion

        }
    }
}
