using System.Web;
using System.Web.Mvc;

namespace N01516955_CumulativeProject_Part2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
