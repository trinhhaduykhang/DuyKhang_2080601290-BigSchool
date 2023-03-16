using System.Web;
using System.Web.Mvc;

namespace DuyKhang_2080601290
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
