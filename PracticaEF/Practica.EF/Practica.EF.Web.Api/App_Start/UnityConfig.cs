using System.Web.Http;
using Unity;
using Unity.WebApi;
using Practica.EF.Service;
using Practica.EF.Service.Interfaces;
using Practica.EF.Service.Services;

namespace Practica.EF.Web.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IShippersService, ShippersService>();
            container.RegisterType<ICustomersService, CustomersService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}