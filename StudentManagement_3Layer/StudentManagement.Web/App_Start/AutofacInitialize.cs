using Autofac;
using Autofac.Integration.Mvc;
using StudentManagement.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace StudentManagement.Web.App_Start
{
    public class AutofacInitialize
    {
        public static void InitializeIoc()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModule(new BusinessModule(WebConfigurationManager.ConnectionStrings["DeafultDb"].ConnectionString));

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}