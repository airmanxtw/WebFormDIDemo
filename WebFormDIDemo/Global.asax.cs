using Autofac;
using Autofac.Integration.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebFormDIDemo.Api;

namespace WebFormDIDemo
{
    public class Global : HttpApplication, IContainerProviderAccessor

    {
        // Provider that holds the application container.
        static IContainerProvider containerProvider;

        // Instance property that will be used by Autofac HttpModules
        // to resolve and inject dependencies.
        public IContainerProvider ContainerProvider
        {
            get { return containerProvider; }
        }



        void Application_Start(object sender, EventArgs e)
        {
            // 應用程式啟動時執行的程式碼
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            containerProvider = new ContainerProvider(CreateContainer());

        }


        public static IContainer CreateContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
          
            //builder.RegisterType<AppService>().As<IAppService>();
            builder.Register(r => new AppService("hello~~~")).As<IAppService>();

            IContainer container = builder.Build();


            return container;
        }



    }
}