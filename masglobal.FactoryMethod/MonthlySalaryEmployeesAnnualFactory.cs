using masglobal.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    class MonthlySalaryEmployeesAnnualFactory : CalculatedAnnualSalaryFactory
    {
        private int _Id;
        private string _TypeContract;
        private readonly IEmployeesApplication _application;

        public MonthlySalaryEmployeesAnnualFactory(int Id, string TypeContract, IEmployeesApplication application)
        {
            _Id = Id;
            _TypeContract = TypeContract;
            _application = application;
        }

        public override CalculatedAnnualSalary GetCalculatedAnnualSalary()
        {
            return new MonthlySalaryEmployeesAnnual(_Id, _TypeContract, _application);
        }
    }
}
