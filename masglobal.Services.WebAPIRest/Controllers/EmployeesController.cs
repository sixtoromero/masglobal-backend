using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using masglobal.Application.Interface;
using masglobal.Application.Main;
using masglobal.ApplicationDTO;
using masglobal.FactoryMethod;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace masglobal.Services.WebAPIRest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesApplication _application;

        public EmployeesController(IEmployeesApplication application)
        {
            this._application = application;
        }

        [HttpGet("{id}/{TypeContract}")]
        public ActionResult<string> GetEmployees(string id, string TypeContract)
        {
            Response<IEnumerable<EmployeesDTO>> response = new Response<IEnumerable<EmployeesDTO>>();

            try
            {
                Creator creator = new Creator(id, TypeContract, _application);
                response = creator.CreatorFactory();

                if (response != null && response.Data != null)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest(response);
                }
                
            }
            catch (Exception)
            {

                throw;
            }

            return id + ' ' + TypeContract;
        }

        //[HttpGet]
        //public IActionResult GetEmployees(string Id)
        //{
        //    Response<IEnumerable<EmployeesDTO>> response = new Response<IEnumerable<EmployeesDTO>>();
        //    try
        //    {
        //        response = _application.GetEmployees(Id);
        //        if (response.IsSuccess)
        //        {
        //            return Ok(response);
        //        } else {
        //            return BadRequest(response);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Data = null;
        //        response.IsSuccess = false;
        //        response.Message = ex.Message;

        //        return BadRequest(response);
        //    }

        //}

    }
}