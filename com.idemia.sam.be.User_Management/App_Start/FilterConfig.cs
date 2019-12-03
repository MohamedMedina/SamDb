using System.Web;
using System.Web.Mvc;

namespace com.idemia.sam.be.User_Management
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
