using masglobal.Application.Interface;
using masglobal.ApplicationDTO;
using masglobal.Domain.Core;
using masglobal.Domain.Interface;
using System;
using System.Collections.Generic;

namespace masglobal.Application.Main
{
    public class EmployeesApplication : IEmployeesApplication
    {
        private readonly IEmployeesDomain _domain;

        public EmployeesApplication(IEmployeesDomain domain)
        {
            _domain = domain;
        }

        public Response<IEnumerable<EmployeesDTO>> GetEmployees(string Id)
        {
            var response = new Response<IEnumerable<EmployeesDTO>>();
            try
            {
                var Employees = _domain.GetEmployees(Id);
                if (Employees != null)
                {
                    response.Data = Employees;
                    response.IsSuccess = true;
                    response.Message = "Process successfully executed";
                }
                else
                {
                    response.Data = null;
                    response.IsSuccess = true;
                    response.Message = "Without results";
                }
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            
            return response;
        }
    }
}
