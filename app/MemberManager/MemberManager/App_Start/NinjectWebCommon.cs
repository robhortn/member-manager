﻿[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MemberManager.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MemberManager.App_Start.NinjectWebCommon), "Stop")]

namespace MemberManager.App_Start
{
    using MemberManager.Data;
    using MemberManager.Domain;
    using MemberManager.Interfaces;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    using System;
    using System.Web;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //kernel.Bind<IMemberRepo>().To<MemberRepo>();
            //kernel.Bind<IMemberDataWriter>().To<MemberDataWriter>();

            //#if DEBUG
            //            kernel.Bind<IMailService>().To<MockMailService>().InRequestScope();

            //#else
            //        kernel.Bind<IMailService>().To<MailService>().InRequestScope();
            //#endif
            //            kernel.Bind<SiteContext>().To<SiteContext>().InRequestScope();
            //            kernel.Bind<IRepository>().To<Repository>().InRequestScope();
            //        }

            kernel.Bind<IMemberDomain>().To<MemberDomain>();
            kernel.Bind<IMemberRepo>().To<MemberRepo>();
        }
    }
}