using masglobal.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    class HourlySalaryEmployeesAnnualFactory : CalculatedAnnualSalaryFactory
    {
        private string _Id;
        private readonly IEmployeesApplication _application;

        public HourlySalaryEmployeesAnnualFactory(string Id, IEmployeesApplication application)
        {
            _Id = Id;
            _application = application;
        }

        public override CalculatedAnnualSalary GetCalculatedAnnualSalary()
        {
            return new HourlySalaryEmployeesAnnual(_Id, _application);
        }
    }
}
