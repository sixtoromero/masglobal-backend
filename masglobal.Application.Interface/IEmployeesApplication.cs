using masglobal.ApplicationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.Application.Interface
{
    public interface IEmployeesApplication
    {
        Response<IEnumerable<EmployeesDTO>> GetEmployees(string Id);
    }
}
