using masglobal.Application.Main;
using masglobal.ApplicationDTO;
using masglobal.Domain.Core;
using masglobal.InfraStructure.Interface;
using masglobal.InfraStructure.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace masglobal.UnitTest
{
    [TestClass]
    public class EmployeesTest
    {
        //private readonly IEmployeesRepository _repository;

        //public EmployeesTest(IEmployeesRepository repository)
        //{
        //    _repository = repository;
        //}

        [TestMethod]
        public void TestGetEmployees()
        {
            EmployeesDomain _domain = new EmployeesDomain(null);
            //Preparación

            EmployeesApplication employees = new EmployeesApplication(_domain);
            var response = new Response<IEnumerable<EmployeesDTO>>();
            try
            {
                response = employees.GetEmployees(string.Empty);
            }
            catch (System.Exception)
            {
                throw;
            }

            //Verificación 
            Assert.AreEqual(true, response.Data != null);
        }
    }
}
