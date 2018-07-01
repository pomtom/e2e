using e2ebusiness.Services;
using e2edata.Repository;
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
            //container.RegisterType(typeof(IBaseRepository<>), typeof(BaseRepository<,>));
            BusinessComponent(container);
            DataBaseComponent(container);
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

            return container;
        }

        private static void DataBaseComponent(UnityContainer container)
        {
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
        }


        private static void BusinessComponent(UnityContainer container)
        {
            container.RegisterType<IEmployeeService, EmployeeService>();
        }

    }
}