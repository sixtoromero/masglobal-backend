using masglobal.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    class SalaryEmployeesAnnualFactory : CalculatedAnnualSalaryFactory
    {
        private readonly int _Id;
        private readonly IEmployeesApplication _application;

        public SalaryEmployeesAnnualFactory(int Id, IEmployeesApplication application)
        {
            _Id = Id;
            _application = application;
        }

        public override CalculatedAnnualSalary GetCalculatedAnnualSalary()
        {
            return new SalaryEmployeesAnnual(_Id, _application);
        }

    }
}
