using System.Web;
using System.Web.Mvc;

namespace PathFinds_Carreer_Guidance
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
