using e2ebusiness.Services;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace e2eapi.Controllers
{
    [RoutePrefix("api/v1/Employee")]
    public class EmployeeController : ApiController
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }


        [Route("")]
        public async Task<IHttpActionResult> Get()
        {
            return Ok(new
            {
                Message = "Hello World!"
            });
        }

        [Route("All")]
        [Authorize]
        [HttpGet]
        public HttpResponseMessage Employees()
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
