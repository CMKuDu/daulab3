﻿using System.Web;
using System.Web.Mvc;

namespace Lab3_TranDau
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
