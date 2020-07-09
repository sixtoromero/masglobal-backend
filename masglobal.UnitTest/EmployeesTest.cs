using masglobal.Application.Interface;
using masglobal.Application.Main;
using masglobal.ApplicationDTO;
using masglobal.Domain.Core;
using masglobal.Domain.Interface;
using masglobal.InfraStructure.Interface;
using masglobal.InfraStructure.Repository;
using masglobal.Services.WebAPIRest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace masglobal.UnitTest
{
    [TestClass]
    public class EmployeesTest
    {
        [TestMethod]
        public void TestGetEmployees()
        {
            //Preparación
            int id = 1;
            string typecontract = "All";
            var response = new Response<IEnumerable<EmployeesDTO>>();

            var mock = new Mock<IEmployeesApplication>();
            mock.Setup(x => x.GetEmployees(id, typecontract)).Returns(response);

            var employeesControoler = new EmployeesController(mock.Object);

            //Prueba
            var result = employeesControoler.GetEmployees(id, typecontract);

            //Verificación
            Assert.IsNotNull(result);
            Assert.AreEqual(result, response.Data);

        }
    }
}
