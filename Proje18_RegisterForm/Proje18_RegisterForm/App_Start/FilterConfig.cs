﻿using System.Web;
using System.Web.Mvc;

namespace Proje18_RegisterForm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
