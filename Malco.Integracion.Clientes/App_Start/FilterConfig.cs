﻿using System.Web;
using System.Web.Mvc;

namespace Malco.Integracion.Clientes
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
