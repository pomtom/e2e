using System;
using e2ebusiness.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using Moq;
using e2edata.Repository;
using System.Collections.Generic;
using e2edata.Models;
using System.Linq;

namespace e2eUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        IUnityContainer container;

        [TestInitialize]
        public void Setup()
        {
            container = UnityConfig.RegisterComponents();
        }

        [TestMethod]
        public void EmployeeServiceShouldReturnStubDataBack()
        {
            EmployeeService employeeService = container.Resolve<EmployeeService>();
            Mock<IEmployeeRepository> employeeRepository = new Mock<IEmployeeRepository>();

            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees { Id = 1, Name = "Pramod", Email = "pramod@gmail.com", Date = DateTime.Now.AddDays(-2) });
            employees.Add(new Employees { Id = 2, Name = "Sachin", Email = "sachin@gmail.com", Date = DateTime.Now.AddDays(-1) });

            employeeRepository.Setup(a => a.GetAllEmployee()).Returns(() => employees.ToList());

            var employeeservice = new EmployeeService(employeeRepository.Object);

            var response = employeeservice.GetAllEmployee();
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.ToList().Count);
        }
    }
}
