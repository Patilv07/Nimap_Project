﻿using System.Web;
using System.Web.Mvc;

namespace Product_Management_System_NimapInfotech
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}