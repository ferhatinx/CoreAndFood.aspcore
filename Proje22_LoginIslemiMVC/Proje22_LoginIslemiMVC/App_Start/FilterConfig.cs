using System.Web;
using System.Web.Mvc;

namespace Proje22_LoginIslemiMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
