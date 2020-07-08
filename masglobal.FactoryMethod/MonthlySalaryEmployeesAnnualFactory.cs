using masglobal.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    class MonthlySalaryEmployeesAnnualFactory : CalculatedAnnualSalaryFactory
    {

        private string _Id;
        private readonly IEmployeesApplication _application;

        public MonthlySalaryEmployeesAnnualFactory(string Id, IEmployeesApplication application)
        {
            _Id = Id;
            _application = application;
        }

        public override CalculatedAnnualSalary GetCalculatedAnnualSalary()
        {
            return new MonthlySalaryEmployeesAnnual(_Id, _application);
        }
    }
}
