﻿using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TCRD_GeneracionSentencia
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }


}


