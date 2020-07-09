using masglobal.Application.Interface;
using masglobal.ApplicationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    class SalaryEmployeesAnnual : CalculatedAnnualSalary
    {
        private readonly int _Id;
        private readonly IEmployeesApplication _application;

        public SalaryEmployeesAnnual(int Id, IEmployeesApplication application)
        {
            _Id = Id;
            _application = application;
        }

        public override Response<IEnumerable<EmployeesDTO>> Employes()
        {
            Response<IEnumerable<EmployeesDTO>> result = null;

            result = _application.GetEmployees(_Id, "All");

            foreach (var item in result.Data)
            {
                switch (item.contractTypeName)
                {
                    case "HourlySalaryEmployee":
                        item.annualSalary = 120 * item.hourlySalary * 12;
                        break;
                    case "MonthlySalaryEmployee":
                        item.annualSalary = item.monthlySalary * 12;
                        break;
                }
                
            }

            return result;
        }

    }
}
