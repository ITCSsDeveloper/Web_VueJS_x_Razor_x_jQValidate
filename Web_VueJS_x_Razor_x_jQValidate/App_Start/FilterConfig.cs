using System.Web;
using System.Web.Mvc;

namespace Web_VueJS_x_Razor_x_jQValidate
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
