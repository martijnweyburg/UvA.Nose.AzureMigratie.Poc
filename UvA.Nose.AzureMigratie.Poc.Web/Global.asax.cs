using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UvA.Nose.AzureMigratie.Poc.Data.Interfaces;
using UvA.Nose.AzureMigratie.Poc.Data.Repositories;
using UvA.Nose.AzureMigratie.Poc.Data.Services;
using UvA.Nose.AzureMigratie.Poc.Web.Controllers;

namespace UvA.Nose.AzureMigratie.Poc.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
