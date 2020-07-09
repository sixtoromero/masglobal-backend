using masglobal.Application.Interface;
using masglobal.ApplicationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.UnitTest.Mocks
{
    public class EmployeesRepositoryMock : IEmployeesApplication
    {
        public Response<IEnumerable<EmployeesDTO>> GetEmployees(int Id, string TypeContract)
        {
            throw new NotImplementedException();
        }
    }
}
