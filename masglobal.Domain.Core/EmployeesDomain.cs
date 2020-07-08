using masglobal.ApplicationDTO;
using masglobal.Domain.Interface;
using masglobal.InfraStructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.Domain.Core
{
    public class EmployeesDomain : IEmployeesDomain
    {
        private readonly IEmployeesRepository _repository;
        public EmployeesDomain(IEmployeesRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<EmployeesDTO> GetEmployees(string Id)
        {
            return _repository.GetEmployees(Id);
        }
    }
}
