using masglobal.ApplicationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.Domain.Interface
{
    public interface IEmployeesDomain
    {
        IEnumerable<EmployeesDTO> GetEmployees(string Id);
    }
}
