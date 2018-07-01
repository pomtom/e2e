using e2ebusiness.Services;
using e2edata.Models;
using e2edata.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity;

namespace e2eUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        IUnityContainer container;
        Mock<IEmployeeRepository> employeeRepository = new Mock<IEmployeeRepository>();
        Mock<IProductRepository> productRepository = new Mock<IProductRepository>();


        [TestInitialize]
        public void Setup()
        {
            container = UnityConfig.RegisterComponents();
            container.Resolve<EmployeeService>();
        }

        [TestMethod]
        public void EmployeeServiceShouldReturnStubDataBack()
        {
            List<Employees> employees = StubEmployees();
            employeeRepository.Setup(a => a.GetAllEmployee()).Returns(() => employees.ToList());

            var employeeservice = new EmployeeService(employeeRepository.Object, productRepository.Object);

            var response = employeeservice.GetAllEmployee();
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.ToList().Count);
        }

        [TestMethod]
        public void GetEmployeeAndProductCount()
        {
            List<Employees> employees = StubEmployees();
            employeeRepository.Setup(a => a.GetAllEmployee()).Returns(() => employees.ToList());

            List<Products> products = StubProducts();
            productRepository.Setup(a => a.GetAllProducts()).Returns(() => products);

            var employeeservice = new EmployeeService(employeeRepository.Object, productRepository.Object);

            var response = employeeservice.GetEmployeeAndProductCount();

            Assert.AreEqual(2, response.Item1);
            Assert.AreEqual(2, response.Item2);
        }

        private static List<Products> StubProducts()
        {
            List<Products> products = new List<Products>();
            products.Add(new Products { Id = 1, ProductName = "C#" });
            products.Add(new Products { Id = 2, ProductName = "asp" });
            return products;

        }

        private static List<Employees> StubEmployees()
        {
            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees { Id = 1, Name = "Pramod", Email = "pramod@gmail.com", Date = DateTime.Now.AddDays(-2) });
            employees.Add(new Employees { Id = 2, Name = "Sachin", Email = "sachin@gmail.com", Date = DateTime.Now.AddDays(-1) });
            return employees;
        }


    }
}
