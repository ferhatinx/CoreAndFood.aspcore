﻿using System.Web;
using System.Web.Mvc;

namespace Proje20_DropdownMenuTennisRegister
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
