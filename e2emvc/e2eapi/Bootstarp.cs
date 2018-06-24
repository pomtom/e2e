using e2ebusiness.Services;
using e2edata.Repository;
using e2eFramework;
using System.Web.Http;
using Unity;

namespace e2eapi
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            BusinessComponent(container);
            DataBaseComponent(container);
            container.RegisterType(typeof(IBaseRepository<>), typeof(BaseRepository<,>));


            return container;
        }

        private static void DataBaseComponent(UnityContainer container)
        {
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
        }

        private static void BusinessComponent(UnityContainer container)
        {
            container.RegisterType<IEmployeeService, EmployeeService>();
        }

    }
}