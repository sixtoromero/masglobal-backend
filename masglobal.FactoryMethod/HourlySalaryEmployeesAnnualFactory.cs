using masglobal.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    class HourlySalaryEmployeesAnnualFactory : CalculatedAnnualSalaryFactory
    {
        private int _Id;
        private string _TypeContract;
        private readonly IEmployeesApplication _application;

        public HourlySalaryEmployeesAnnualFactory(int Id, string TypeContract, IEmployeesApplication application)
        {
            _Id = Id;
            _TypeContract = TypeContract;
            _application = application;
        }

        public override CalculatedAnnualSalary GetCalculatedAnnualSalary()
        {
            return new HourlySalaryEmployeesAnnual(_Id, _TypeContract, _application);
        }
    }
}
