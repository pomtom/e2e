using e2ebusiness.Services;
using e2edata.Repository;
using Unity;

namespace e2eUnitTest
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer();
            BusinessComponent(container);
            DataBaseComponent(container);

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