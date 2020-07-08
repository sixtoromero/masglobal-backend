using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using masglobal.Application.Interface;
using masglobal.ApplicationDTO;
using masglobal.FactoryMethod;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace masglobal.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesApplication _application;

        public EmployeesController(IEmployeesApplication application)
        {
            _application = application;
        }

        [HttpGet("{id}/{TypeContract}")]
        public ActionResult<string> GetEmployees(string id, string TypeContract)
        {
            //Response<IEnumerable<EmployeesDTO>> response = new Response<IEnumerable<EmployeesDTO>>();
            
            //try
            //{
            //    Creator creator = new Creator(id, TypeContract, _application);
            //    response = creator.CreatorFactory();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            
            return id + ' ' + TypeContract;
        }
    }
}