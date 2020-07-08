using masglobal.ApplicationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.InfraStructure.Interface
{
    public interface IEmployeesRepository
    {
        IEnumerable<EmployeesDTO> GetEmployees(string Id);
    }
}
