using System.Web;
using System.Web.Mvc;

namespace Practica.EF.Web.MVC.PokeApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
