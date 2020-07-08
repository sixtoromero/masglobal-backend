using masglobal.Application.Interface;
using masglobal.ApplicationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    class MonthlySalaryEmployeesAnnual : CalculatedAnnualSalary
    {
        private string _Id;
        private readonly IEmployeesApplication _application;

        public MonthlySalaryEmployeesAnnual(string Id, IEmployeesApplication application)
        {
            _Id = Id;
            _application = application;
        }

        public override Response<IEnumerable<EmployeesDTO>> Employes()
        {
            Response<IEnumerable<EmployeesDTO>> result = null;
            result = _application.GetEmployees(_Id);

            foreach (var item in result.Data)
            {
                item.annualSalary = item.monthlySalary * 12;
            }

            return result;
        }

    }
}
