using e2ebusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace e2eapi.Controllers
{
    public class EmployeeController : ApiController
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var vr = _employeeService.GetAllEmployee();
                return Request.CreateResponse(HttpStatusCode.OK, vr);
            }
            catch (System.Exception ex)
            {
                string msg = string.Empty;
                if (ex.InnerException != null)
                {
                    msg = ex.InnerException.Message;
                }
                else
                {
                    msg = ex.Message;
                }
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
