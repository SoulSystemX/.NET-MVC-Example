﻿using System.Web;
using System.Web.Mvc;

namespace dot_NET_MVC_Example
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
