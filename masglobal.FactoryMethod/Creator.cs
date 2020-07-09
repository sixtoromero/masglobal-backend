using masglobal.Application.Interface;
using masglobal.ApplicationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    public class Creator
    {
        private int _Id;
        private string _TypeContract;
        private IEmployeesApplication _application;

        public Creator(int Id, string TypeContract, IEmployeesApplication application)
        {
            _Id = Id;
            _TypeContract = TypeContract;
            _application = application;
        }

        public Response<IEnumerable<EmployeesDTO>> CreatorFactory()
        {
            Response<IEnumerable<EmployeesDTO>> request = new Response<IEnumerable<EmployeesDTO>>();
            CalculatedAnnualSalaryFactory factory = null;
            switch (_TypeContract)
            {
                case "HourlySalaryEmployee":
                    factory = new HourlySalaryEmployeesAnnualFactory(_Id, _TypeContract, _application);
                    break;
                case "MonthlySalaryEmployee":
                    factory = new MonthlySalaryEmployeesAnnualFactory(_Id, _TypeContract, _application);
                    break;
                default:
                    factory = new SalaryEmployeesAnnualFactory(_Id, _application);
                    break;
            }

            var result = factory.GetCalculatedAnnualSalary();
            request = result.Employes();

            return request;
        }
    }
}
