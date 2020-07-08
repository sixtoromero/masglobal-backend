using masglobal.ApplicationDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace masglobal.FactoryMethod
{
    public abstract class CalculatedAnnualSalary
    {
        public abstract Response<IEnumerable<EmployeesDTO>> Employes();
    }
}
