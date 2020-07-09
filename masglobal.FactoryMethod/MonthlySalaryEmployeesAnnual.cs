using masglobal.Application.Interface;
using masglobal.ApplicationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    class MonthlySalaryEmployeesAnnual : CalculatedAnnualSalary
    {
        private int _Id;
        private string _TypeContract;
        private readonly IEmployeesApplication _application;

        public MonthlySalaryEmployeesAnnual(int Id, string TypeContract, IEmployeesApplication application)
        {
            _Id = Id;
            _TypeContract = TypeContract;
            _application = application;
        }

        public override Response<IEnumerable<EmployeesDTO>> Employes()
        {
            Response<IEnumerable<EmployeesDTO>> result = null;
            result = _application.GetEmployees(_Id, _TypeContract);

            foreach (var item in result.Data)
            {
                item.annualSalary = item.monthlySalary * 12;
            }

            return result;
        }

    }
}
